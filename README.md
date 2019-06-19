# Blazor
A shallow dive into the various Blazor models Microsoft is suggesting

## What?

We're going to explore the two models that Microsoft are suggesting to use Blazor: 

- Client side
- Server side

For more information see the various Microsoft documentation pages:

- [Introduction to Blazor](https://docs.microsoft.com/en-gb/aspnet/core/blazor/?view=aspnetcore-3.0)
- [Blazor hosting models](https://docs.microsoft.com/en-gb/aspnet/core/blazor/hosting-models?view=aspnetcore-3.0)

Alternatively, have a look at the [slide deck](https://docs.google.com/presentation/d/14Alzq_0sARMq86yJHCnewmsBFa4rTq3I8gEoIEiZ8r0/edit?usp=sharing) for this meetup.

## Getting started

To start with the following need to be setup on your machine:


	1. Install `SDK 3.0.100-preview5-011568` - https://dotnet.microsoft.com/download/dotnet-core/3.0
	2. Install Blazor templates - `dotnet new -i Microsoft.AspNetCore.Blazor.Templates::3.0.0-preview5-19227-01`
	3. Install VS 2019 (preview) - https://visualstudio.microsoft.com/vs/preview/
  4. Install Blazor Extension (via VS 2019)

More information [here](https://docs.microsoft.com/en-us/aspnet/core/blazor/get-started?view=aspnetcore-3.0) 

## Blazor Client Side

1. Create a `Client Side Blazor` project in VS
2. Run!

Next, we'll create a component called `Actors`. This will use the csv file in the repo. We will need: 

- a service to fetch the data
- a component to display the data in table format

Finally, add a two-way binding button to increment the number of actors to display.

## Blazor Server Side

1. Create a `Server Side Blazor` project in VS
2. Run!

Follow the same steps above to fetch data and display on the page. Find out how much code can actually be copied across or shared!
