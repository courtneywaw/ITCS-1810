Module Module1

    Sub Main()

        Dim charlie As Dog
        Dim stuart As Dog

        charlie = New Dog
        stuart = New Dog

        charlie.name = "charles"
        charlie.breed = "poodle"
        charlie.Age = 17
        charlie.BFF = stuart

        stuart.name = "stuart"
        stuart.breed = "golden retriever"
        stuart.Age = 8
        stuart.BFF = charlie

        Dim youngest As Dog = stuart
    End Sub

End Module
