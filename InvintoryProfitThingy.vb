    'Dim margin, Profit, totalCost, superTotalValue, superUnitCost, superSellingPrice As Double
    Dim margin, superUnitCost, totalCost, sellingPrice, totalValue, totalProfit As Double
    Dim superItemsOnHand As Integer


    Private Sub InvintoryProfit()

        superItemsOnHand = itemsOnHand.Value
        margin = (marginValue.Value / 100)
        superUnitCost = unitCost.Value

        'Calculate Total Cost
        totalCost = itemsOnHand.Value * unitCost.Value
        lblTotalCost.Text = Format(totalCost, "Currency")

        'Calculate Selling Price

        sellingPrice = unitCost.Value / (1 - margin)

        lblSellingPrice.Text = Format(sellingPrice, "Currency")

        'Calculate Total Value
        totalValue = sellingPrice * superItemsOnHand
        lblTotalValue.Text = Format(totalValue, "Currency")

        'Calculate Total Profit
        totalProfit = totalValue - totalCost
        lblTotalProfit.Text = Format(totalProfit, "Currency")




        'lblTotalValue.Text = Format(superTotalValue, "Currency") 'Currency is needed here, it actualy changes how it measures stuff, if you put Total here like lasttime then it wouldnt work.
        'lblTotalCost.Text = Format(totalCost, "Currency")
        'lblSellingPrice.Text = Format(superSellingPrice, "Currency")
        'lblTotalProfit.Text = Format(Profit, "Currency")


        'totalCost = itemsOnHand.Value * unitCost.Value

        'Profit = lblTotalValue.Text - lblTotalCost.Text

        'superTotalValue = lblSellingPrice.Text * itemsOnHand.Value

        'superSellingPrice = (unitCost.Value * marginValue.Value) + unitCost.Value

        'margin = (marginValue.Value / 100)
        'superSellingPrice = unitCost.Value / (1 - margin)

        'superItemsOnHand = itemsOnHand.Value



    End Sub



    Private Sub lblTotalCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalCost.Click
        InvintoryProfit()
        '    itemsOnHand * unitCost Good
    End Sub

    Private Sub lblTotalValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        InvintoryProfit()
        '    SellingPrice * itemsOnHand Good
    End Sub

    Private Sub lblSellingPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSellingPrice.Click
        InvintoryProfit()
        '    (unitCost * margin%) + unitCost
    End Sub

    Private Sub lblTotalProfit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        InvintoryProfit()
        '    totalValue(-totalCost) Good
    End Sub

    Private Sub itemsOnHand_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemsOnHand.ValueChanged
        InvintoryProfit()
    End Sub

    Private Sub unitCost_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unitCost.ValueChanged
        InvintoryProfit()
    End Sub

    Private Sub marginValue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles marginValue.Scroll
        lblMarginValue.Text = marginValue.Value & "%"
        InvintoryProfit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        marginValue.Value = 30
        margin = marginValue.Value
        lblMarginValue.Text = (margin & "%")
    End Sub
End Class
