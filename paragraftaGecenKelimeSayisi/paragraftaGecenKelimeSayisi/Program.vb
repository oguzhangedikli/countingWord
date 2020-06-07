Imports System

Module Program
    Sub Main()
        Dim dictionary As New Dictionary(Of String, Integer)
        Dim metin As String
        metin = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi sagittis urna non tellus blandit, vitae finibus enim blandit. Integer vel hendrerit neque. Nullam sed lorem pulvinar, sodales nisi at, sollicitudin ante. Pellentesque eget gravida justo, non feugiat metus. Proin ornare, diam lobortis egestas tempor, dolor ex sollicitudin ante, in faucibus lectus lacus in turpis. Aenean sit amet fringilla purus. Nulla ante ligula, finibus vitae nisl a, scelerisque dapibus mauris. Nunc lobortis tellus vitae ipsum semper, in consectetur purus iaculis. Duis commodo sapien arcu, eu ultricies dolor pellentesque nec. Nunc vestibulum ligula luctus, finibus orci ullamcorper, laoreet nisi. Nunc auctor tellus a libero malesuada pulvinar. Ut risus dolor, dignissim ut malesuada vitae, ultricies quis justo. Maecenas pharetra efficitur orci, sed mattis odio porttitor vel. Maecenas placerat mollis dui, eu pellentesque ante gravida at. Phasellus faucibus, felis at tristique maximus, sem nisi vestibulum arcu, et viverra velit ex sed nulla. Nulla mi."

        Dim list As String() = metin.Split(" ")

        For Each item As String In list

            If Not dictionary.ContainsKey(item) Then
                dictionary.Add(item, 1)

            Else
                Dim intValue1 As Integer = dictionary.Item(item)
                Dim dict_key As String = item
                dictionary.Remove(item)
                dictionary.Add(item, intValue1 + 1)

            End If

        Next

        Dim sorted = From pair In dictionary
                     Order By pair.Value Descending
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        For Each item As KeyValuePair(Of String, Integer) In sortedDictionary

            Console.WriteLine(metin & vbCrLf & "" & vbCrLf & "Yukarýda bulunan 150 kelimelik paragrafta" & vbCrLf & "{0} Kelimesi en fazla geçen kelimedir ve {1} kez geçmiþtir.", item.Key, item.Value)
            Exit For
        Next

        Console.WriteLine("Çýkmak için herhangi bir tuþa basýn.")
        Console.ReadLine()


    End Sub
End Module

