

<h2 align="center">OcrSpace.Sharp - A tiny .NET client for the OcrSpace API</h2>

<p align="center">
    <img src="https://img.shields.io/nuget/v/OcrSpace.Sharp?color=1f72de" alt="Nuget">
    <img src="https://img.shields.io/badge/-.NET%20Standard%202.0-blueviolet?color=1f72de&label=NET" alt="">
    <img src="https://img.shields.io/github/license/russkyc/ocrspace-sharp">
    <img src="https://img.shields.io/github/issues/russkyc/ocrspace-sharp">
    <img src="https://img.shields.io/nuget/dt/OcrSpace.Sharp">
</p>

<p style="text-align: justify">
<a href="https://ocr.space/">OCRSpace</a> offers a free and paid Optical character recognition service. This package provides a tiny client that
encapsulates the api endpoint into a single class for scanning images.
</p>

## :sparkles: What Parameter Options are currently Supported

This client is in active development and not all parameters are enabled as of now, to track the status of parameter suport please refer to the table below:

### Parameter Support (Post Endpoint)

<table>
  <tr>
    <th>Parameter</th>
    <th>Enabled</th>
  </tr>
  <tr>
    <td>Language</td>
    <td>False</td>
  </tr>
  <tr>
    <td>IsOverlayRequired</td>
    <td>False</td>
  </tr>
  <tr>
    <td>FileType</td>
    <td>False</td>
  </tr>
  <tr>
    <td>DetectOrientation</td>
    <td>False</td>
  </tr>
  <tr>
    <td>IsCreateSearchablePdf</td>
    <td>False</td>
  </tr>
  <tr>
    <td>Scale</td>
    <td>False</td>
  </tr>
  <tr>
    <td>IsTable</td>
    <td>False</td>
  </tr>
  <tr>
    <td>OcrEngine</td>
    <td>False</td>
  </tr>
</table>

## :notebook: Client Reference

### Read From File

```csharp
var client = new OcrSpaceClient("K88461247188957");
var result = await client.ReadFromFile("/Images/SampleImage.png");
```

## :heart: Donate

This is free and available for everyone to use, but still requires time for development
and maintenance. By choosing to donate, you are not only helping develop this project,
but you are also helping me dedicate more time for creating more tools that help the community :heart:

## :tada: Special Thanks

This project is made easier to develop by Jetbrains! They have provided
Licenses to their IDE's to support development of this open-source project.

<a href="https://www.jetbrains.com/community/opensource/#support">
<img width="200px" src="https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.png" alt="JetBrains Logo (Main) logo.">
</a>