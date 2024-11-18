# Image Filtration App

![image](https://github.com/user-attachments/assets/bc9f5a25-19e3-481f-a111-341b4dbe55d4)

A simple WPF application for applying image processing filters using OpenCV. Users can load images, apply filters such as sharpening, noise smoothing, and grayscale conversion, and then save the modified images.

## Features

- Load and display images.
- Apply filters:
  - Sharpening (using Laplacian).
  - Noise smoothing (using erosion).
  - Grayscale conversion.
- Save processed images.
- Interactive interface for applying filters and saving results.

## Technologies Used

- **WPF**: User interface framework.
- **OpenCV**: Image processing algorithms.
- **OpenCvSharp**: .NET wrapper for OpenCV.
  
## Getting Started

1. Clone the repository:
    ```bash
    git clone https://github.com/Cladkoewka/ImageProcessing.git
    ```

2. Open the project in Visual Studio or any other compatible IDE.

3. Install dependencies via NuGet Package Manager:
    - `OpenCvSharp4`
    - `OpenCvSharp4.runtime.win`

4. Build and run the application.

## Usage

- Click **Load Image** to load an image from your computer.
- Apply filters by clicking the corresponding buttons.
- Use **Save Image** to save the processed image to your desired location.

## License

This project is open-source and available under the MIT License.
