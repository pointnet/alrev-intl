# Alrev.Intl

[![license](https://img.shields.io/github/license/pointnet/alrev-intl)](LICENSE)
[![coveralls](https://coveralls.io/repos/github/pointnet/alrev-intl/badge.svg?branch=develop)](https://coveralls.io/github/pointnet/alrev-intl?branch=develop)
[![build-master](https://github.com/pointnet/alrev-intl/actions/workflows/build-master.yml/badge.svg)](https://github.com/pointnet/alrev-intl/actions/workflows/build-master.yml)
[![build-develop](https://github.com/pointnet/alrev-intl/actions/workflows/build-develop.yml/badge.svg)](https://github.com/pointnet/alrev-intl/actions/workflows/build-develop.yml)

This repository is the home of Alrev.Intl and related libraries. 

Inspired by [@FormatJS](https://github.com/formatjs/formatjs) work.

## Packages

| Package | Version | Changelog |
| :--- | :---: | :---: |
| [Alrev.Intl.Abstractions](packages/Alrev.Intl.Abstractions/) | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.Abstractions)](https://www.nuget.org/packages/Alrev.Intl.Abstractions/) [![github](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/pointnet/8738e44902f9f103575dfa796d42fa73/raw/Alrev.Intl.Abstractions.json)](https://github.com/pointnet/alrev-intl/packages/721940) | [CHANGELOG](packages/Alrev.Intl.Abstractions/CHANGELOG.md) |
| [Alrev.Intl.PluralRules](packages/Alrev.Intl.PluralRules) | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.PluralRules)](https://www.nuget.org/packages/Alrev.Intl.PluralRules/) [![github](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/pointnet/8738e44902f9f103575dfa796d42fa73/raw/Alrev.Intl.PluralRules.json)](https://github.com/pointnet/alrev-intl/packages/723692) | [CHANGELOG](packages/Alrev.Intl.PluralRules/CHANGELOG.md) |
| [Alrev.Intl.PluralRules.DependencyInjection](packages/Alrev.Intl.PluralRules.DependencyInjection) | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.PluralRules.DependencyInjection)](https://www.nuget.org/packages/Alrev.Intl.PluralRules.DependencyInjection/) [![github](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/pointnet/8738e44902f9f103575dfa796d42fa73/raw/Alrev.Intl.PluralRules.DependencyInjection.json)](https://github.com/pointnet/alrev-intl/packages/724114) | [CHANGELOG](packages/Alrev.Intl.PluralRules.DependencyInjection/CHANGELOG.md) |
| [Alrev.Intl.RelativeTime](packages/Alrev.Intl.RelativeTime) | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.RelativeTime)](https://www.nuget.org/packages/Alrev.Intl.RelativeTime/) [![github](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/pointnet/8738e44902f9f103575dfa796d42fa73/raw/Alrev.Intl.RelativeTime.json)](https://github.com/pointnet/alrev-intl/packages/723736) | [CHANGELOG](packages/Alrev.Intl.RelativeTime/CHANGELOG.md) |
| [Alrev.Intl.RelativeTime.DependencyInjection](packages/Alrev.Intl.RelativeTime.DependencyInjection) | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.RelativeTime.DependencyInjection)](https://www.nuget.org/packages/Alrev.Intl.RelativeTime.DependencyInjection/) [![github](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/pointnet/8738e44902f9f103575dfa796d42fa73/raw/Alrev.Intl.RelativeTime.DependencyInjection.json)](https://github.com/pointnet/alrev-intl/packages/724135) | [CHANGELOG](packages/Alrev.Intl.RelativeTime.DependencyInjection/CHANGELOG.md) |
| [Alrev.Intl.List](packages/Alrev.Intl.List) | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.List)](https://www.nuget.org/packages/Alrev.Intl.List/) [![github](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/pointnet/8738e44902f9f103575dfa796d42fa73/raw/Alrev.Intl.List.json)](https://github.com/pointnet/alrev-intl/packages/728870) | [CHANGELOG](packages/Alrev.Intl.List/CHANGELOG.md) |
| [Alrev.Intl.List.DependencyInjection](packages/Alrev.Intl.List.DependencyInjection) | [![nuget](https://img.shields.io/nuget/v/Alrev.Intl.List.DependencyInjection)](https://www.nuget.org/packages/Alrev.Intl.List.DependencyInjection/) [![github](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/pointnet/8738e44902f9f103575dfa796d42fa73/raw/Alrev.Intl.List.DependencyInjection.json)](https://github.com/pointnet/alrev-intl/packages/) | [CHANGELOG](packages/Alrev.Intl.List.DependencyInjection/CHANGELOG.md) |

## Development

We currently use packages from the [CLDR - Unicode Common Locale Data Repository](https://github.com/unicode-org/cldr-json) and [dotnet-script](https://github.com/filipw/dotnet-script) to generate csharp  code.

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
