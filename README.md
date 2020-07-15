# 👑 CvGenerator

Open-source .NET Core based project to provide a web-based tool to generate online Cvs.

## 💻 What tools we use

- [MediatR](https://github.com/jbogard/MediatR)
- [Moq](https://github.com/moq/moq)
- [xUnit](https://github.com/xunit/xunit)
- [Docker](https://www.docker.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## 💣 Usage

This tool can be used by following [this web](http://www.nrn.com.ar/cv-generator) or cloning/downloading the source code.

If you want to run this code locally, run `CG.Web` project or use the following commands:

```` Dotnet
dotnet run --project CvGenerator/CG.Web/CG.Web.csproj
````

or using Docker:

```` Docker
docker build -t cv-generator . -f CvGenerator/CG.Web/Dockerfile`
docker run -d cv-generator
````

## 🤙 Contributing

Contributions are welcome! 🙌

Please feel free to submit pull requests to help:

- Fix errors.
- Refactoring.
- Build the Front End.
- Submit issues and bugs.
- Propose new ideas.

## 💎 License

Made with ❤ from Argentina to the world 🌐
