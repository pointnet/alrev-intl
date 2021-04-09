# Alrev.Intl

[![license](https://img.shields.io/github/license/pointnet/alrev-intl)](LICENSE)
[![coveralls](https://coveralls.io/repos/github/pointnet/alrev-intl/badge.svg?branch=develop)](https://coveralls.io/github/pointnet/alrev-intl?branch=develop)
[![build-develop](https://github.com/pointnet/alrev-intl/actions/workflows/build-develop.yml/badge.svg)](https://github.com/pointnet/alrev-intl/actions/workflows/build-develop.yml)

This repository is the home of Alrev.Intl and related libraries. 

Inspired by [@FormatJS](https://github.com/formatjs/formatjs) work.

## Packages

| [Alrev.Intl.Abstractions](packages/Alrev.Intl.Abstractions/) | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.Abstractions)](https://www.nuget.org/packages/Alrev.Intl.Abstractions/) |
| :--- | :---: |
| __[Alrev.Intl.PluralRules](packages/Alrev.Intl.PluralRules)__ | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.PluralRules)](https://www.nuget.org/packages/Alrev.Intl.PluralRules/) |
| __[Alrev.Intl.RelativeTime](packages/Alrev.Intl.RelativeTime)__ | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.RelativeTime)](https://www.nuget.org/packages/Alrev.Intl.RelativeTime/) |

## Development

We currently use packages from the [
CLDR - Unicode Common Locale Data Repository](https://github.com/unicode-org/cldr-json) and [dotnet-script](https://github.com/filipw/dotnet-script) to generate csharp  code.

To setup locally, first restore packages from `npm` and `dotnet tool`:
```
> npm i
> dotnet tool restore
```

### npm scripts
```
> npm run cldr-plural-rules    // generate resources and unit tests for Alrev.Intl.PluraRules
> npm run cldr-relative-time   // generate resources and unit tests for Alrev.Intl.RelativeTime
> npm run test                 // run dotnet test locally and generate coverage reports in "~/.coverage"
```