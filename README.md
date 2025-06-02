# Arcadia-ArcadeManager
A tool for remotely managing one or more batocera / retroarch / mame installs.

This tool will contain multiple components.

## Remote Access Client
A remote access client that lives on the device, acting as an RPC client. This client will allow for listing of games, other files, stuff like that. This could be installing a game from a network location, restarting the machine, grabbing high scores, setting machines up for tournament play.

**Common approach:**  
- Use a lightweight language/runtime (e.g., Go, Rust, or Python) for portability and minimal dependencies.
- Package as a single binary or with minimal dependencies.
- Use gRPC or REST for communication.
- Provide a simple CLI for device-side operations.

## Server
The next tool is the server, which will initiate the RPC process. The server can also reside on the same machine as one of the batocera installs. Potential to offer this as a service.

**Common approach:**  
- Implement as a REST or gRPC server.
- Use Docker for easy deployment and portability.
- Provide authentication and authorization for secure access.
- Optionally, use a lightweight web framework (e.g., FastAPI, Express.js, or ASP.NET Core).

## Command Line Tool
Next will be a command line tool for scripting and testing API calls.

**Common approach:**  
- Implement in a scripting language (e.g., Python, Node.js) for easy modification.
- Use standard CLI argument parsing libraries.
- Support configuration via environment variables or config files.

## Web Based UI
Finally there will be a web based UI.

**Common approach:**  
- Use a modern frontend framework (e.g., React, Vue, or Svelte).
- Serve as a static site or via the server component.
- Communicate with the server via REST/gRPC APIs.

---

**Portability Tips:**  
- Prefer static binaries or containers for deployment.
- Minimize external dependencies on edge devices.
- Use cross-compilation or multi-arch Docker images for different device architectures (e.g., ARM, x86).
- Document installation steps for each platform.

...