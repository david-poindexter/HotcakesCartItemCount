Imports Hotcakes.Commerce.Extensions
Imports Hotcakes.Commerce.Orders

Public Class HotcakesCartCount
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Create instance of Hotcakes Commerce
        Dim HccApp = HccAppHelper.InitHccApp()

        'Get current cart
        Dim currentCart = HccApp.OrderServices.CurrentShoppingCart

        'Populate label with current cart item count 
        lblCartCount.Text = currentCart.Items.Count.ToString

    End Sub

End Class