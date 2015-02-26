Module Module1

    Sub Main()
        Dim Courtney As Person
        Dim Taylor As Person

        Courtney = New Person
        Taylor = New Person

        Courtney.firstname = "Courtney"
        Courtney.lastname = "Wawrowski"

        Taylor.firstname = "Taylor"
        Taylor.lastname = "Wawrowski"

        Dim petx As Pet
        Dim pety As Pet
        Dim petz As Pet

        petx = New Pet
        pety = New Pet
        petz = New Pet

        petx.petname = "Fluffy"
        petx.age = 2
        petx.species = "golden lab"
        petx.owner = Courtney

        pety.petname = "Winston"
        pety.age = 4
        pety.species = "yorkie"
        pety.owner = Taylor

        petz.petname = "Pearl"
        petz.age = 6
        petz.species = "rabbit"
        petz.owner = Taylor

        Console.WriteLine(petx.petname)
        Console.WriteLine(petx.age)
        Console.WriteLine(petx.species)
        Console.WriteLine(petx.owner.fullname)

        Console.WriteLine(pety.petname)
        Console.WriteLine(pety.age)
        Console.WriteLine(pety.species)
        Console.WriteLine(pety.owner.fullname)

        Console.WriteLine(petz.petname)
        Console.WriteLine(petz.age)
        Console.WriteLine(petz.species)
        Console.WriteLine(petz.owner.fullname)

        Console.ReadKey()



    End Sub

End Module
