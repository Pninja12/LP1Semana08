```mermaid
classDiagram
    class Program {

    }
    class Animal {
        +string Sound()
    }
    class Bat {
        +int NumberOfNipples
        +int NumberOfWings
        +string Sound()
    }
    class Bee {
        +int NumberOfWings
        +string Sound()
    }
    class Cat {
        +int NumberOfNipples
        +string Sound()
    }
    class Dog {
        +int NumberOfNipples
        +string Sound()
    }
    class ICanFly {
        int NumberOfWings
    }
    class IMammal {
        int NumberOfNipples
    }

    Program --> Animal
    Program ..> Bat
    Program ..> Bee
    Program ..> Cat
    Program ..> Dog
    Bat ..|> IMammal
    Bat ..|> ICanFly
    Cat ..|> IMammal
    Dog ..|> IMammal
    Bee ..|> ICanFly
    Bat --|> Animal
    Cat --|> Animal
    Dog --|> Animal
    Bee --|> Animal
