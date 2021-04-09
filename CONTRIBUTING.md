# Contributing Guide

Before submitting your contribution though, please make sure to take a moment and read through the following guidelines.

- [Issue Reporting Guidelines](#issue-reporting-guidelines)
- [Pull Request Guidelines](#pull-request-guidelines)
- [Development Setup](#development-setup)

## Issue Reporting Guidelines
- Before filing a new issue, try to make sure your problem doesn’t already exist.
- The best way to get your bug fixed is to provide a reduced test case.

## Pull Request Guidelines
Before submitting a pull request, please make sure the following is done:

- Fork the repository and create your branch from `master`.

## Development Setup
We currently use packages from the [
CLDR - Unicode Common Locale Data Repository](https://github.com/unicode-org/cldr-json) and [dotnet-script](https://github.com/filipw/dotnet-script) to generate csharp  code.

To setup locally, first restore packages from `npm` and `dotnet tool`:
```
> npm i
> dotnet tool restore
```
