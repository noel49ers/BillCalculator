Module Module1

    Sub Main()
        'This program calculates a bill for a car garage.
        Dim BillPaid As String = "Y"
        While BillPaid = "Y"
            'Restarts program if bill paid 
            Console.WriteLine("Enter a name")
            Dim Name As String = Console.ReadLine
            Console.WriteLine("Enter labour hours")
            Dim Labour As Single = Console.ReadLine
            Console.WriteLine("Enter the part type")
            Dim TypeOfParts As String = Console.ReadLine
            Console.WriteLine("Enter the parts cost before tax")
            Dim CostOfParts As Single = Console.ReadLine
            Dim LabourCost As Single = Labour * 25
            CostOfParts = CostOfParts * 1.05
            Dim TotalCost As Single = CostOfParts + LabourCost
            Console.WriteLine("Enter a discount code. If there are none, enter 0. Student code is 323125. OAP code is 457389. Military veteran code is 981273")
            Dim Discount As String
            Dim Code As String = Console.ReadLine
            If Code = "323125" Then
                TotalCost = TotalCost * 0.9
                Discount = "Student"
            ElseIf Code = "457389" Then
                Discount = "OAP"
                TotalCost = TotalCost * 0.8
            ElseIf Code = "981273" Then
                TotalCost = TotalCost * 0.7
                Discount = "Military veteran"
            ElseIf Code = 0 Then
                TotalCost = TotalCost
                Discount = "None"
            Else
                Console.WriteLine("Invalid code.")
                Discount = "None"
            End If
            'Checks discount codes 
            Console.WriteLine("Name is " & Name & ". Labour cost is £" & LabourCost & ". Cost of parts is £" & CostOfParts & " . Total cost is £" & TotalCost & ". Part bought is " & TypeOfParts & ".")
            'Name of parts added 
            Console.WriteLine("Is the bill paid? Y/N")
            BillPaid = Console.ReadLine
        End While
        'Asks If bill Is paid 
    End Sub

End Module
