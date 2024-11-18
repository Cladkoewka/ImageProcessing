using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using OpenCvSharp;
using OpenCvSharp.WpfExtensions;

namespace ImageFiltrationApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : System.Windows.Window
{
    private Mat? _currentImage;
    
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void LoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                _currentImage = Cv2.ImRead(openFileDialog.FileName);
                if (_currentImage.Empty())
                {
                    MessageBox.Show("Ошибка загрузки изображения.");
                    return;
                }
                ImageView.Source = _currentImage.ToWriteableBitmap();
            }
        }

        private void SaveImage_Click(object sender, RoutedEventArgs e)
        {
            if (_currentImage == null)
            {
                MessageBox.Show("Нет изображения для сохранения.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                Cv2.ImWrite(saveFileDialog.FileName, _currentImage);
                MessageBox.Show("Изображение сохранено.");
            }
        }

        private void SharpenImage_Click(object sender, RoutedEventArgs e)
        {
            if (_currentImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение.");
                return;
            }

            // Преобразование изображения в 64F для совместимости
            Mat image64F = new Mat();
            _currentImage.ConvertTo(image64F, MatType.CV_64F);

            Mat laplacian = new Mat();
            Cv2.Laplacian(image64F, laplacian, MatType.CV_64F);

            Mat sharpened = new Mat();
            Cv2.AddWeighted(image64F, 1.5, laplacian, -0.5, 0, sharpened);

            // Преобразуем обратно в исходный тип (например, 8U)
            sharpened.ConvertTo(_currentImage, _currentImage.Type());

            ImageView.Source = _currentImage.ToWriteableBitmap();
        }


        private void SmoothNoise_Click(object sender, RoutedEventArgs e)
        {
            if (_currentImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение.");
                return;
            }

            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(3, 3));
            Mat eroded = new Mat();
            Cv2.Erode(_currentImage, eroded, kernel);

            _currentImage = eroded;
            ImageView.Source = _currentImage.ToWriteableBitmap();
        }
        
        private void ConvertToGrayscale_Click(object sender, RoutedEventArgs e)
        {
            if (_currentImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение.");
                return;
            }

            // Проверка, если изображение уже в оттенках серого (1 канал)
            if (_currentImage.Channels() == 1)
            {
                MessageBox.Show("Изображение уже в оттенках серого.");
                return;
            }
            
            // Преобразуем изображение в оттенки серого
            Mat grayImage = new Mat();
            Cv2.CvtColor(_currentImage, grayImage, ColorConversionCodes.BGR2GRAY);

            // Обновляем изображение в интерфейсе
            _currentImage = grayImage;
            ImageView.Source = _currentImage.ToWriteableBitmap();
        }

        
        private void CropAndResize_Click(object sender, RoutedEventArgs e)
        {
            // Показываем панель ввода координат
            CoordinateInputPanel.Visibility = Visibility.Visible;
            ButtonsPanel.Visibility = Visibility.Collapsed;
        }

        private void CropImage_Click(object sender, RoutedEventArgs e)
        {
            if (_currentImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение.");
                return;
            }

            // Получаем координаты из текстовых полей
            if (int.TryParse(LeftTopXTextBox.Text, out int leftTopX) &&
                int.TryParse(LeftTopYTextBox.Text, out int leftTopY) &&
                int.TryParse(RightBottomXTextBox.Text, out int rightBottomX) &&
                int.TryParse(RightBottomYTextBox.Text, out int rightBottomY))
            {
                if (leftTopX < 0 || leftTopY < 0 || rightBottomX > _currentImage.Width || rightBottomY > _currentImage.Height)
                {
                    MessageBox.Show("Координаты выходят за пределы изображения.");
                    return;
                }

                if (!(rightBottomX > leftTopX) || !(rightBottomY > leftTopY))
                {
                    MessageBox.Show("Неверные координаты");
                    return; 
                }

                // Создаем прямоугольную область для обрезки
                OpenCvSharp.Rect roi = new OpenCvSharp.Rect(leftTopX, leftTopY, rightBottomX - leftTopX, rightBottomY - leftTopY);

                // Выполняем обрезку изображения
                _currentImage = new Mat(_currentImage, roi);

                // Обновляем отображение изображения
                ImageView.Source = _currentImage.ToWriteableBitmap();
                
                CoordinateInputPanel.Visibility = Visibility.Collapsed;
                ButtonsPanel.Visibility = Visibility.Visible;
                CropRectangle.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите правильные координаты.");
            }
        }
        
        private void UpdateCropRectangle()
        {
            if (_currentImage == null) return;

            // Проверяем, что введенные координаты валидны
            if (int.TryParse(LeftTopXTextBox.Text, out int leftTopX) &&
                int.TryParse(LeftTopYTextBox.Text, out int leftTopY) &&
                int.TryParse(RightBottomXTextBox.Text, out int rightBottomX) &&
                int.TryParse(RightBottomYTextBox.Text, out int rightBottomY))
            {
                // Проверяем, что координаты находятся в пределах изображения
                if (leftTopX >= 0 && leftTopY >= 0 && rightBottomX <= _currentImage.Width && rightBottomY <= _currentImage.Height
                    && rightBottomX > leftTopX && rightBottomY > leftTopY)
                {
                    // Обновляем прямоугольник на канвасе
                    CropRectangle.Visibility = Visibility.Visible;
                    CanvasOverlay.Width = _currentImage.Width;
                    CanvasOverlay.Height = _currentImage.Height;

                    // Устанавливаем размеры и положение прямоугольника
                    Canvas.SetLeft(CropRectangle, leftTopX);
                    Canvas.SetTop(CropRectangle, leftTopY);
                    CropRectangle.Width = rightBottomX - leftTopX;
                    CropRectangle.Height = rightBottomY - leftTopY;
                }
                else
                {
                    CropRectangle.Visibility = Visibility.Collapsed; // Скрываем рамку, если координаты выходят за пределы изображения
                }
            }
        }

        private void LeftTopXTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Console.WriteLine("Left Top");
            UpdateCropRectangle();
        }

        private void LeftTopYTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) => 
            UpdateCropRectangle();

        private void RightBottomXTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) => 
            UpdateCropRectangle();

        private void RightBottomYTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) => 
            UpdateCropRectangle();
}