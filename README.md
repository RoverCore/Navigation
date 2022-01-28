# What is RoverCore Navigation?

RoverCore Navigation is a Razor Class Library that provides a service to load navigation menus from appsettings.json.  Menu items 
are filtered automatically by role to reduce the menu to only the options the user has permission for.

## How to setup

```csharp
services.AddScoped<NavigationService>();
```

## ViewComponent Usage

When you want the menu to appear simply include the following code in one of your razor pages.

```csharp
@(await Component.InvokeAsync<NavbarViewComponent>())
```

## Example Menu Configuration
```json
{
"Navigation": [
    {
      "NavMenuItems": [
        {
          "Text": "Home",
          "Type": "link",
          "Controller": "Home",
          "Action": "Index",
          "Values": {
            "Area": "Dashboard"
          },
          "Icon": "las la-home",
          "Roles": [ "User", "Admin" ]
        },
        {
          "Text": "Dropdown",
          "Type": "dropdown",
          "Controller": "Home",
          "Action": "Index",
          "Values": {
            "Area": "Dashboard"
          },
          "Icon": "las la-dumpster",
          "Roles": [ "User", "Admin" ],
          "Children": [
            {
              "Text": "Dropdown 1",
              "Type": "link",
              "Controller": "Home",
              "Action": "Index",
              "Values": {
                "Area": "Dashboard"
              },
              "Icon": "ti-home",
              "Roles": [ "User", "Admin" ]
            },
            {
              "Text": "Dropdown 2",
              "Type": "dropdown",
              "Icon": "ti-home",
              "Roles": [ "User", "Admin" ],
              "Children": [
                {
                  "Text": "Dropdown 3",
                  "Type": "link",
                  "Controller": "Home",
                  "Action": "Index",
                  "Values": {
                    "Area": "Dashboard"
                  },
                  "Icon": "ti-home",
                  "Roles": [ "User", "Admin" ]
                },
                {
                  "Text": "Dropdown 4",
                  "Type": "dropdown",
                  "Icon": "ti-home",
                  "Roles": [ "User", "Admin" ],
                  "Children": [
                    {
                      "Text": "Dropdown 5",
                      "Type": "link",
                      "Controller": "Home",
                      "Action": "Index",
                      "Values": {
                        "Area": "Dashboard"
                      },
                      "Icon": "ti-home",
                      "Roles": [ "User", "Admin" ]
                    },
                    {
                      "Text": "Dropdown 6",
                      "Type": "link",
                      "Icon": "ti-home",
                      "Roles": [ "User", "Admin" ]
                    }
                  ]
                }
              ]

            }
          ]
        },
        {
          "Text": "Documentation",
          "Type": "link",
          "Url": "https://rovercore.github.io/RoverCoreDocs/docs/",
          "Icon": "las la-file-alt",
          "Roles": [ "User", "Admin" ]
        }
      ]
    }
  ]
}
```