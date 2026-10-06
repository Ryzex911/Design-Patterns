# Decorator Pattern - NotificationApp

C# Console App voor **Design Patterns - Decorator Pattern**.

Open `NotificationApp.csproj` met Visual Studio en start met `Ctrl+F5`.

## Mappen

- `Services`: originele Email- en SmsNotificationService.
- `Inheritance`: oefeningen 2 en 3 (extra subclasses).
- `Decorators`: basisdecorator + Logging, Urgent en Timestamp.
- `Program.cs`: tests voor opdracht 1-3, 6-10 en eindopdracht.

De eindopdracht gebruikt deze keten:

```text
Program
  -> LoggingNotificationDecorator
      -> TimestampNotificationDecorator
          -> UrgentNotificationDecorator
              -> SmsNotificationService
```

De theorievragen staan in het aparte Word-document.

**Let op:** de twee basisservices hebben `virtual Send` voor de vroege inheritance-oefeningen. De decorator-oefeningen wijzigen deze services niet.
