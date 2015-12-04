
    Dim tax, subTotal, total As Decimal

    Dim taxRate As Decimal = 0.08
    Dim burrito As Decimal = 5.95
    Dim taco As Decimal = 7.95
    Dim bowl As Decimal = 6.95
    Dim beef As Decimal = 1.5
    Dim chicken As Decimal = 1.25
    Dim pork As Decimal = 1.0
    Dim lamb As Decimal = 2.0
    Dim lettuce As Decimal = 0.5
    Dim cheese As Decimal = 0.5
    Dim beans As Decimal = 0.75
    Dim tomato As Decimal = 0.5
    Dim chips As Decimal = 1.0
    Dim fries As Decimal = 1.0
    Dim soup As Decimal = 1.5
    Dim small As Decimal = 1.25
    Dim medium As Decimal = 1.5
    Dim large As Decimal = 2.0

    Private Sub clearTheCustomerSelections()

        btnNoneMainItems.Checked = True
        btnNoneMeats.Checked = True
        btnLettuce.Checked = False
        btnCheese.Checked = False
        btnTomato.Checked = False
        btnBeans.Checked = False
        btnChips.Checked() = False
        btnFries.Checked = False
        btnSoup.Checked = False
        btnSmall.Checked = False
        btnMedium.Checked = False
        btnLarge.Checked = False


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        initializeVariables()
        clearTheCustomerSelections()
        clearReceipt()

    End Sub

    Private Sub initializeVariables()

        subTotal = 0
        tax = 0
        total = 0

    End Sub

    Private Sub clearReceipt() 'for each new customer

        listBoxDisplay.Items.Clear() 'clear the customer checked
        listBoxTotal.Items.Clear()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        initializeVariables()
        clearTheCustomerSelections()
        clearReceipt()
    End Sub

    Private Sub btnAddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click

        computeCurrentSelection()
        updateTotal()
        clearTheCustomerSelections()

    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Me.Close()

    End Sub

    Private Sub computeCurrentSelection()

        If btnBurrito.Checked Then
            subTotal += burrito

            Dim BurritoItem As String = burrito.ToString("C") & " Burrito"
            listBoxDisplay.Items.Add(BurritoItem)
        End If

        If btnTaco.Checked Then
            subTotal += taco

            Dim TacoItem As String = taco.ToString("C") & " Taco"
            listBoxDisplay.Items.Add(TacoItem)
        End If

        If btnBowl.Checked Then
            subTotal += bowl

            Dim bowlItem As String = bowl.ToString("C") & " Bowl"
            listBoxDisplay.Items.Add(bowlItem)
        End If

        If btnBeef.Checked Then
            subTotal += beef
            Dim beefItem As String = beef.ToString("C") & " Beef"
            listBoxDisplay.Items.Add(beefItem)
        End If

        If btnChicken.Checked Then
            subTotal += chicken

            Dim chickenItem As String = chicken.ToString("C") & " Chicken"
            listBoxDisplay.Items.Add(chickenItem)
        End If

        If btnPork.Checked Then
            subTotal += pork

            Dim porkItem As String = pork.ToString("C") & " Pork"
            listBoxDisplay.Items.Add(porkItem)
        End If

        If btnLamb.Checked Then
            subTotal += lamb

            Dim lambItem As String = lamb.ToString("C") & " Lamb"
            listBoxDisplay.Items.Add(lambItem)
        End If

        If btnLettuce.Checked Then
            subTotal += lettuce

            Dim lettuceItem As String = lettuce.ToString("C") & " Lettuce"
            listBoxDisplay.Items.Add(lettuceItem)
        End If

        If btnCheese.Checked Then
            subTotal += cheese

            Dim cheeseItem As String = cheese.ToString("C") & " Cheese"
            listBoxDisplay.Items.Add(cheeseItem)
        End If

        If btnBeans.Checked Then
            subTotal += beans

            Dim beansItem As String = beans.ToString("C") & " Beans"
            listBoxDisplay.Items.Add(beansItem)
        End If

        If btnTomato.Checked Then
            subTotal += tomato

            Dim tomatoItem As String = tomato.ToString("C") & " Tomato"
            listBoxDisplay.Items.Add(tomatoItem)
        End If

        If btnChips.Checked Then
            subTotal += chips

            Dim chipsItem As String = chips.ToString("C") & " Chips"
            listBoxDisplay.Items.Add(chipsItem)
        End If

        If btnFries.Checked Then
            subTotal += fries

            Dim FriesItem As String = fries.ToString("C") & " Fries"
            listBoxDisplay.Items.Add(FriesItem)
        End If

        If btnSoup.Checked Then
            subTotal += soup

            Dim soupItem As String = soup.ToString("C") & " Soup"
            listBoxDisplay.Items.Add(soupItem)
        End If

        If btnSmall.Checked Then
            subTotal += small

            Dim smallItem As String = small.ToString("C") & " Small"
            listBoxDisplay.Items.Add(smallItem)
        End If

        If btnMedium.Checked Then
            subTotal += medium

            Dim mediumItem As String = medium.ToString("C") & " Medium"
            listBoxDisplay.Items.Add(mediumItem)
        End If

        If btnLarge.Checked Then
            subTotal += large

            Dim largeItem As String = large.ToString("C") & " Large"
            listBoxDisplay.Items.Add(largeItem)
        End If



    End Sub

    Private Sub updateTotal()

        'Clear the previous subtotal, tax and total
        listBoxTotal.Items.Clear()

        'Compute and display the subtotal
        listBoxTotal.Items.Add("SUB TOTAL = " & subTotal.ToString("C"))

        'Compute and display the tax
        tax = subTotal * taxRate
        listBoxTotal.Items.Add("             TAX = " & tax.ToString("C"))

        'Compute and display the total
        total = subTotal + tax
        listBoxTotal.Items.Add("        TOTAL = " & total.ToString("C"))

        'Separate each person's order on the receipt
        listBoxDisplay.Items.Add("------------------------")

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
