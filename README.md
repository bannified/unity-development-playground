# unity-development-playground
Personal repository for development of Unity/C# packages/tools/utility.

Different packages in development can be found in different packages.

`master` branch should only contain boilerplate code for package development.


### Usage Instructions:

* While the Unity Editor does compile PrettyBigInteger successfully, Visual Studio might not be throwing errors and not recognize System.Numerics.
 * How to Fix : Add the reference of System.Numeric.dll in Visual Studio
   * for Mac:
   * for Windows:
 * This is due to the mcs.rsp file adding the reference of .NET System.Numeric.dll to Unity Editor but not Visual Studio
 * The aforementioned fix has to be applied every time you open Visual Studio.
