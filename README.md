# SharpPhysX
## Status
Track progress **[here](https://github.com/Alan-FGR/SharpPhysX/projects/1)**.
Items in the Review column are implemented and generally safe to use.
### Platforms Support
The bindings are .NET Standard 2.0 and the native wrapper should be compilable with any modern C/C++ compiler.
Currently there's a VS solution because of bugs with the CMake integration I don't have time or patience to deal with.
Only supported platform is 64-bit, I don't plan to support 32-bit but that should be very trivial if you need that.
## Future Plans
### EasyPhysy
This is going to be a high-level abstraction that makes it very easy to use the library.
Not only a very simplified API is planned, but also fully automatic memory management.