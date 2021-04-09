# Contributing Guide

Before submitting your contribution though, please make sure to take a moment and read through the following guidelines.

- [Issue Reporting Guidelines](#issue-reporting-guidelines)
- [Pull Request Guidelines](#pull-request-guidelines)
- [Git Commit Messages](#git-commit-messages)
- [Development Setup](#development-setup)

## Issue Reporting Guidelines
- Before filing a new issue, try to make sure your problem doesn’t already exist.
- The best way to get your bug fixed is to provide a reduced test case.

## Pull Request Guidelines
Before submitting a pull request, please make sure the following is done:

- Fork the repository and create your branch from `develop`.

## Git Commit Messages

Commits should start with a Capital letter and should be written in present tense (e.g. __:tada: Add cool new feature__ instead of __:tada: Added cool new feature__).
You should also start your commit message with **one** applicable emoji. This does not only look great but also makes you rethink what to add to a commit. Make many but small commits!

| Emoji | Description |
| ------|------------ |
| :tada: `:tada:` | When you added a cool new feature. |
| :wrench: `:wrench:` | When you refactored / improved a small piece of code. |
| :hammer: `:hammer:` | When you refactored / improved large parts of the code. |
| :sparkles: `:sparkles:` | When you applied clang-format. |
| :art: `:art:` | When you improved / added assets like themes. |
| :rocket: `:rocket:` | When you improved performance. |
| :memo: `:memo:` | When you wrote documentation. |
| :beetle: `:beetle:` | When you fixed a bug. |
| :twisted_rightwards_arrows: `:twisted_rightwards_arrows:` | When you merged a branch. |
| :fire: `:fire:` | When you removed something. |
| :truck: `:truck:` | When you moved / renamed something. |

## Development Setup
We currently use packages from the [
CLDR - Unicode Common Locale Data Repository](https://github.com/unicode-org/cldr-json) and [dotnet-script](https://github.com/filipw/dotnet-script) to generate csharp  code.

To setup locally, first restore packages from `npm` and `dotnet tool`:
```
> npm i
> dotnet tool restore
```
