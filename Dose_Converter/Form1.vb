
Public Class frmDoseConverter

    Private Sub frmDoseConverter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Forms load event sets default radiobutton and loads the combobox
        Me.radbtnDose.Checked = True
        'originally assigned variable amounts of...  this was based on the old program calculator. 
        'R=115.07
        'mR=115074.8
        'uR=115074798.62
        'Gy=1
        'mGy=1000
        'uGy=1000000
        'added nano Gy for Philips Pulsera Carms 11/16/2013
        'nGy=1000000000
        Me.cboxUnitFrom.Items.Add("R")
        Me.cboxUnitFrom.Items.Add("mR")
        Me.cboxUnitFrom.Items.Add("uR")
        Me.cboxUnitFrom.Items.Add("Gy")
        Me.cboxUnitFrom.Items.Add("mGy")
        Me.cboxUnitFrom.Items.Add("uGy")
        Me.cboxUnitFrom.Items.Add("nGy")

        Me.cboxUnitTo.Items.Add("R")
        Me.cboxUnitTo.Items.Add("mR")
        Me.cboxUnitTo.Items.Add("uR")
        Me.cboxUnitTo.Items.Add("Gy")
        Me.cboxUnitTo.Items.Add("mGy")
        Me.cboxUnitTo.Items.Add("uGy")
        Me.cboxUnitTo.Items.Add("nGy")

    End Sub

    Private Sub radbtnRate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radbtnRate.CheckedChanged

        If radbtnRate.Checked = True Then
            Me.cboxRateTo.Visible = True
            Me.cboxRateTo.Items.Add("/Hour")
            Me.cboxRateTo.Items.Add("/Minute")
            Me.cboxRateTo.Items.Add("/Second")

            Me.cboxRateFrom.Visible = True
            Me.cboxRateFrom.Items.Add("/Hour")
            Me.cboxRateFrom.Items.Add("/Minute")
            Me.cboxRateFrom.Items.Add("/Second")

        End If

        If radbtnRate.Checked = False Then
            Me.cboxRateTo.Items.Clear()
            Me.cboxRateTo.Visible = False
            Me.cboxRateFrom.Items.Clear()
            Me.cboxRateFrom.Visible = False

        End If

    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim Value As Decimal
        Dim Answer As Decimal
        Dim ConversionValueFrom As Decimal
        Dim ConversionValueTo As Decimal
        Dim RateConversionValueFrom As Decimal
        Dim RateConversionValueTo As Decimal

        Try

            If Me.cboxUnitFrom.SelectedIndex = -1 Then
                MessageBox.Show("You must select a unit of measurement to convert From", "Error")
            Else
                'changed value to 114.2 according to ge mammo manual
                Select Case Me.cboxUnitFrom.SelectedIndex
                    Case (0)
                        ConversionValueFrom = 114.2
                    Case (1)
                        ConversionValueFrom = 114200
                    Case (2)
                        ConversionValueFrom = 114200000
                    Case (3)
                        ConversionValueFrom = 1
                    Case (4)
                        ConversionValueFrom = 1000
                    Case (5)
                        ConversionValueFrom = 1000000
                    Case (6)
                        ConversionValueFrom = 1000000000
                End Select
            End If

            If Me.cboxUnitTo.SelectedIndex = -1 Then
                MessageBox.Show("You must select a unit of measurement to convert To", "Error")
            Else
                Select Case Me.cboxUnitTo.SelectedIndex
                    Case (0)
                        ConversionValueTo = 114.2
                    Case (1)
                        ConversionValueTo = 114200
                    Case (2)
                        ConversionValueTo = 114200000
                    Case (3)
                        ConversionValueTo = 1
                    Case (4)
                        ConversionValueTo = 1000
                    Case (5)
                        ConversionValueTo = 1000000
                    Case (6)
                        ConversionValueTo = 1000000000
                End Select
            End If

            'here is the part of the program where I will determine if rate is selected if so change the conversion #.
            If Me.radbtnRate.Checked = True Then

                If Me.cboxRateFrom.SelectedIndex = -1 Then
                    MessageBox.Show("You must select a Rate unit of measurement to convert From", "Error")
                Else
                    Select Case Me.cboxRateFrom.SelectedIndex
                        Case (0)
                            RateConversionValueFrom = 3600
                        Case (1)
                            RateConversionValueFrom = 60
                        Case (2)
                            RateConversionValueFrom = 1
                    End Select
                End If

                If Me.cboxRateTo.SelectedIndex = -1 Then
                    MessageBox.Show("You must select a Rate unit of measurement to convert To", "Error")
                Else
                    Select Case Me.cboxRateTo.SelectedIndex
                        Case (0)
                            RateConversionValueTo = 3600
                        Case (1)
                            RateConversionValueTo = 60
                        Case (2)
                            RateConversionValueTo = 1
                    End Select
                End If

            End If

            Value = Convert.ToDecimal(Me.txtValue.Text)

            If Me.chkboxScientificNotation.Checked = True Then

            End If

            If Me.radbtnRate.Checked = True Then
                Answer = ((ConversionValueTo / ConversionValueFrom) / (RateConversionValueFrom / RateConversionValueTo)) * Value
                Me.txtResults.Text = Me.txtResults.Text & String.Format(Value) & cboxUnitFrom.SelectedItem & cboxRateFrom.SelectedItem & " = " & String.Format("{0:n3}", Answer) & cboxUnitTo.SelectedItem & cboxRateTo.SelectedItem & ControlChars.NewLine
            Else
                Answer = (ConversionValueTo / ConversionValueFrom) * Value
                'Displays the results in the text box for non rate calculations
                Me.txtResults.Text = Me.txtResults.Text & String.Format(Value) & cboxUnitFrom.SelectedItem & " = " & String.Format("{0:n3}", Answer) & cboxUnitTo.SelectedItem & ControlChars.NewLine
            End If

            'must be after the answer is determined in either fashion
            If Me.chkboxScientificNotation.Checked = True Then
                Me.lblScientificNotation.Text = String.Format("{0:e3}", Answer)
                'will also need to make a seperate event so if scientific notaion is checked again place original text back in label

            End If

            Me.txtValue.Focus()
            Me.txtValue.SelectAll()

            'These 2 lines of code autoscrolls to bottom of the txtresults
            Me.txtResults.SelectionStart = Me.txtResults.Text.Length
            Me.txtResults.ScrollToCaret()

        Catch ex As Exception
            MessageBox.Show("Must enter a value other than 0.  Must use numbers only.", "Error Message")
            Me.txtValue.Focus()
            Me.txtValue.SelectAll()
        End Try

    End Sub

    Private Sub chkboxScientificNotation_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkboxScientificNotation.CheckedChanged
        Me.lblScientificNotation.Text = "Add Scientific Notation"
    End Sub

    Private Sub cmnuAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuAbout.Click
        MessageBox.Show("This program was created by Shane Talbert." & ControlChars.NewLine & "FE for GE Healthcare.  Email me at shane.talbert@ge.com" & ControlChars.NewLine & "This program was written on the assumption that 114.2 R = 1 Gy.  This was taken from the GE Mammo service manual on the Seno Essential.", "About the Dose Converter Program")
    End Sub
End Class
