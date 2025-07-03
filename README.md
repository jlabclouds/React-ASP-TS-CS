# ReactFullStackTS# React ASP.NET Core TypeScript with Linux Container Support

This project is a starter framework that combines **React** (frontend), **ASP.NET Core** (backend), and **TypeScript** for building modern web applications. It is pre-configured to run seamlessly in Linux containers, making it ideal for cloud-native deployments and development workflows.

## Best Use Cases

This starter framework is ideal for a variety of modern development scenarios, including:

- **Full-stack web applications:** Build robust solutions that require a powerful backend (ASP.NET Core) and a dynamic, responsive frontend (React). Perfect for dashboards, portals, and interactive web platforms.
- **Microservices and APIs:** Easily containerize your backend services for deployment on Kubernetes, Docker Swarm, or other orchestrators. The project structure supports scalable, maintainable API development.
- **Cross-platform development:** Develop and test in Linux-based containers to ensure consistency between local, staging, and production environments. This approach minimizes "works on my machine" issues and streamlines CI/CD pipelines.
- **Enterprise-grade applications:** Leverage TypeScript for enhanced type safety, maintainability, and developer productivity. The stack is well-suited for large teams and long-term projects where code quality and reliability are critical.
- **Cloud-native deployments:** Take advantage of seamless integration with cloud platforms and container registries, enabling rapid deployment and scaling in cloud environments such as Azure, AWS, or Google Cloud.
- **Rapid prototyping:** Quickly scaffold new projects with a ready-to-use setup, reducing initial configuration time and allowing teams to focus on feature development.

Whether you're building a new SaaS product, internal business tools, or public-facing web services, this template provides a solid foundation for modern, scalable, and maintainable applications.

## Getting Started

### Prerequisites

- [.NET 7 SDK or later](https://dotnet.microsoft.com/download)
- [Node.js (LTS)](https://nodejs.org/)
- [Docker](https://www.docker.com/get-started) (for container support)

### Running Locally

1. **Clone the repository:**
    ```bash
    git clone <repository-url>
    cd React-ASP-TS-CS
    ```

2. **Install frontend dependencies:**
    ```bash
    cd ClientApp
    npm install
    cd ..
    ```

3. **Run the application:**
    ```bash
    dotnet run
    ```
    The backend will start, and the React frontend will be served via ASP.NET Core.

### Running in a Linux Container

1. **Build the Docker image:**
    ```bash
    docker build -t react-asp-ts-cs .
    ```

2. **Run the container:**
    ```bash
    docker run -p 5000:80 react-asp-ts-cs
    ```
    The app will be available at [http://localhost:5000](http://localhost:5000).

## Project Structure

- `ClientApp/` — React + TypeScript frontend
- `Controllers/` — ASP.NET Core API controllers
- `Dockerfile` — Container configuration
- `Startup.cs` / `Program.cs` — ASP.NET Core setup

## License

This project is licensed under the MIT License.