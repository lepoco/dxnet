<img src="https://github.com/lepoco/dxnet/blob/main/Resources/dxnet.png?raw=true" width="100" height="100">  
  
# DX .NET

[![GitHub license](https://img.shields.io/github/license/lepoco/dxnet)](https://github.com/lepoco/dxnet/blob/master/LICENSE) [![NET](https://img.shields.io/badge/.NET-6.0.0-red)](https://github.com/lepoco/DXNET/blob/main/DXNET/DXNET.csproj) [![Nuget](https://img.shields.io/nuget/v/DXNET)](https://www.nuget.org/packages/DXNET) [![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/DXNET?label=nuget-pre)](https://www.nuget.org/packages/DXNET/) [![Nuget](https://img.shields.io/nuget/dt/DXNET?label=nuget-downloads)](https://www.nuget.org/packages/DXNET/)

DX .NET, a fork of [SharpDX](http://sharpdx.org), is free software allowing the development of high performance game, 2D and 3D graphics rendering as well as realtime sound application.  
One of the assumptions of the fork was to cut it off from other libraries and add the generated C++ headers to the code, so that compilation is not dependent on any libraries. DX .NET uses only the capabilities of the .NET platform.

## Hall of fame
// TODO

## What's included?
| Name| Framework | Status |
| --- | --- | --- | 
| **DXNET** <br /> The core assembly providing infrastructure for all managed DirectX API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.Animation** <br /> Assembly providing DirectX - Animation managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.D3DCompiler** <br /> Managed Direct3D Compiler API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.Desktop** <br /> Assembly providing APIs related to Desktop platform. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.Direct2D1** <br /> Assembly provides managed API for **DXNET.Direct2D1**, **DXNET.DirectWrite** and **DXNET.WIC**. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.Direct3D9** <br /> Assembly providing DirectX - Direct3D9 managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.Direct3D10** <br /> Assembly providing DirectX - Direct3D10 and Direct3D10.1 managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.Direct3D11** <br /> Assembly providing DirectX - Direct3D11, Direct3D11.1 and Effects11 managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.Direct3D11.Effects** <br /> Assembly providing DirectX - Effects11 managed API for Direct3D11. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.Direct3D12** <br /> Assembly providing DirectX - Direct3D12 managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.DirectComposition** <br /> Assembly providing DirectX - DirectComposition managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.DirectInput** <br /> Assembly providing DirectX - DirectInput managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.DirectManipulation** <br /> Assembly providing DirectX - DirectManipulation managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.DirectSound** <br /> Assembly providing DirectX - DirectSound managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.DXGI** <br /> Assembly providing DirectX - DXGI managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.Mathematics** <br /> Assembly providing DirectX - Mathematics managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.MediaFoundation** <br /> Assembly providing DirectX - MediaFoundation managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.RawInput** <br /> Assembly providing DirectX - RawInput managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.XAudio2** <br /> Assembly providing DirectX - XAudio2, X3DAudio and XAPO managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |
| **DXNET.XInput** <br /> Assembly providing DirectX - XInput managed API. | .NET 6 | [![Build status](https://github.com/lepoco/dxnet/workflows/CI/badge.svg)](https://github.com/lepoco/dxnet/actions) |

## Documentation
// TODO

## Build

In order to compile **DX .NET**, you need to install **Visual Studio 2022 or newer** with the following workloads and components:

- [x] Visual C++ Toolset Component
- [x] Windows 10 SDK Component
- [x] C# Development Workload
- [x] .NET Core Cross Platform Development Workload


## License
**DX .NET** is free and open source software licensed under MIT License. You can use it in private and commercial projects. Keep in mind that you must include a copy of the license in your project.