# Factory Pattern - Starbuzz

Deze opdracht gebruikt het Factory Method Pattern samen met de bestaande Decorator-structuur.

## Belangrijk
De barista bestelt via `DrinkFactory`.
De keuze is een `DrinkType` enum.
Daardoor kan via de factory alleen een drank uit de kaart worden gekozen.

## Pattern
- `DrinkFactory` = abstract Creator
- `StarbuzzDrinkFactory` = Concrete Creator
- `CreateDrink()` = Factory Method
- `Beverage` = Product
- `Espresso`, `Chocolate` en de Decorators = Concrete Products / opbouw van het product
