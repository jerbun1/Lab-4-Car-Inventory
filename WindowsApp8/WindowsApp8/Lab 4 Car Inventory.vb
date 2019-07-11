Option Strict On

Public Class frmCarInventory

    Private carList As New SortedList
    Private currentCarIdentificationNumber As String = String.Empty
    Private editMode As Boolean



    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Cars
        Dim carItem As ListViewItem

        If isCarInputValid() = True Then

            editMode = True

            lbResult.Text = "Its Alive!!"

            If currentCarIdentificationNumber.Trim.Length = 0 Then
                car = New Cars(chkNew.Checked, txtPrice.Text, cmbYear.Text, txtModel.Text, cmbMake.Text)
                carList.Add(car.identificationNumber.ToString, car)

            Else
                car = CType(carList.Item(currentCarIdentificationNumber), Cars)
                car.NewCar = chkNew.Checked
                car.Price = txtPrice.Text
                car.Year = cmbYear.Text
                car.Model = txtModel.Text
                car.Make = cmbMake.Text




            End If

            lvwCarList.Items.Clear()

            For Each carEntry As DictionaryEntry In carList

                carItem = New ListViewItem()

                car = CType(carEntry.Value, Cars)

                carItem.Checked = car.NewCar
                carItem.SubItems.Add(car.Price)
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Make)

                carItem.SubItems.Add(car.identificationNumber.ToString())

                lvwCarList.Items.Add(carItem)

            Next carEntry
            Reset()
            editMode = False


        End If



    End Sub

    Private Function isCarInputValid() As Boolean
        Dim returnValue As Boolean = True
        Dim resultMessage As String = String.Empty

        If cmbMake.SelectedIndex = -1 Then

            resultMessage += "Please select the cars Make." & vbCrLf
            returnValue = False
        End If

        If txtModel.Text.Trim.Length = 0 Then
            resultMessage += "Please enter a model for the car." & vbCrLf
            returnValue = False

        End If

        If txtPrice.Text.Trim.Length = 0 Then
            resultMessage += "Please enter a Price for the car." & vbCrLf
            returnValue = False

        End If

        If cmbYear.SelectedIndex = -1 Then
            resultMessage += "Please select a year for the car." & vbCrLf
            returnValue = False

        End If

        If returnValue = False Then
            lbResult.Text = "Errors" & vbCrLf & resultMessage

        End If

        Return returnValue

    End Function



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        cmbMake.Items.Clear()

        cmbYear.Items.Clear()
        chkNew.Checked = False
        lvwCarList.Items.Clear()



    End Sub

    Private Sub lvwCarList_ItemsCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarList.ItemCheck

        If editMode = False Then
            e.NewValue = e.CurrentValue
        End If
    End Sub

    Private Sub lvwCarList_SelectedIndexChanges(sender As Object, e As EventArgs) Handles lvwCarList.SelectedIndexChanged

        Const identificationSubItemIndex As Integer = 1

        currentCarIdentificationNumber = lvwCarList.Items(lvwCarList.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        Dim car As Cars = CType(carList.Item(currentCarIdentificationNumber), Cars)

        txtModel.Text = car.Model
        txtPrice.Text = car.Price
        cmbMake.Text = car.Make
        cmbYear.Text = car.Year
        chkNew.Checked = car.NewCar

        lbResult.Text = car.GetCar()
    End Sub


End Class
