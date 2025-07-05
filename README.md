# Partas.Solid.Start.Template

Template to get started with Fable + Solid-Start using Partas.Solid.

This is a great way to just get started with Partas.Solid and Solid-js and explore the SolidStart meta frame-work routing system et al.

To deploy this with a dotnet server, you would have to have more intimate knowledge of configuring SolidStart to plugin your own backend. To take the most advantage of SolidStart, you would likely move in the direction of having the solid-start backend communicate with your own backend.

> Uses the FAKE build process from the SAFE stack.

> By default has solid-devtools installed. This is only present in dev builds and is automatically removed in production builds.

## Setup

Clone the repository, go to the root of the repository and run:

```
dotnet run setup
```

This will:
1. Install Fable tooling
2. Install Dotnet Packages
3. Install NPM Packages
4. Run the development server

> Installing the NPM Packages will take a while on the first run, be patient!

## Deployment

There is no premade setup for this. You can use the FAKE build system by modifying the `Build.fs` file to suit your needs.

Alternatively, you can just commit all `.fs.jsx` created in the dev process to a branch, and then deploy using Vercel or Netlify or whatever else is supported by Solid-Start from there.

This is in the scenario that you are not deploying with a dotnet server.

## Commands

1. Setup

See above.

```
dotnet run setup
```

2. Dev

Starts the development server.

```
dotnet run dev
```

3. Restore

Installs any missing dotnet/npm dependencies.

```
dotnet run restore
```
