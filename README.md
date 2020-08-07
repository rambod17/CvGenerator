# 👑 CvGenerator

[![Build Status](https://dev.azure.com/NCRZ06/CvGenerator/_apis/build/status/NICORUIZ06.CvGenerator?branchName=master)](https://dev.azure.com/NCRZ06/CvGenerator/_build/latest?definitionId=6&branchName=master)

Open-source .NET Core based project to provide a web-based tool to generate an online resume.

## 😷 Introduction

Due to the emergence of the COVID-19 virus, many people lost their jobs and the possibility of generating income. There are many people who have never been able to create their own resume in an easy and simple way. That is why this tool is intended to create a web application that can help everyone to create their resume in the easiest and fastest way possible, with the idea of ​​giving the possibility of completing the following steps:

1. Upload personal data and general information
2. Upload a picture
3. Include optional details (sections) such as work experience, education, languages, aptitudes/virtues, etc.
4. Choose a template
5. Download/share the generated resume

In fact, it is intended to create the possibility of importing this data from profiles such as LinkedIn or Google with one click.

The person can also manage their resumes in a special section of type "my account", being able to have many resumes in different languages ​​or types (one sales resume and another as administrative for example).

This application has been thought of in 2 projects: one web and the other an API type, which can be used to create a mobile application in the future.

## 💻 What tools we use

- [MediatR](https://github.com/jbogard/MediatR)
- [Moq](https://github.com/moq/moq)
- [xUnit](https://github.com/xunit/xunit)
- [Docker](https://www.docker.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Swagger](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [ASP.NET API Versioning](https://github.com/microsoft/aspnet-api-versioning)

## 💣 Usage

This tool can be used by following [this web](#TBD) or cloning/downloading the source code.

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

If you have any question or suggestion, please contact me by sending an email to nicolasruizneiman@gmail.com

## 💎 License

Made with ❤ from Argentina to the world 🌐
