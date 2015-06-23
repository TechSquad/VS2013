Public Class frmCategoryMenu
    Dim MyTable As DataTable

    Private Sub frmCategoryMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim CatCode, CatName As String
        Dim a As Integer = 0
        Dim a1 As Integer = 0
        Dim b1 As Integer = 0
        Dim c1 As Integer = 0
        Dim oNode As TreeNode

        MyTable = getTargetCatPath()
        dgvCategories.DataSource = MyTable
        dgvCategories.Refresh()
        TreeView1.Nodes.Add(New TreeNode("Target Components"))      'Set Initial Node
        'level 1
        For Each Row As DataRow In MyTable.Rows    'Walk through the datatable one record at a time
            CatCode = Row("CatCode").ToString
            CatName = Row("CatName").ToString

            If Not FindNode(TreeView1.Nodes, Row("Level1").ToString, oNode) Then
                If Row("Level1").ToString <> "" Then TreeView1.Nodes(0).Nodes.Add(New TreeNode(Row("Level1").ToString)) ' node not found so add it
                a += 1
            Else
                a1 = oNode.Index
            End If
        Next
        'Level 2
        For Each Row As DataRow In MyTable.Rows    'Walk through the datatable one record at a time
            CatCode = Row("CatCode").ToString
            CatName = Row("CatName").ToString
            If FindNode(TreeView1.Nodes, Row("Level1").ToString, oNode) Then        ' Find level one node - it must exist as this is level 2
                'aTrue = True
                a1 = oNode.Index    'set node number
                If Not FindNode(TreeView1.Nodes, Row("Level2").ToString, oNode) Then    'look for level 2 node
                    If Row("Level2").ToString <> "" Then TreeView1.Nodes(0).Nodes(a1).Nodes.Add(New TreeNode(Row("Level2").ToString)) ' node not found so add it
                Else
                    b1 = oNode.Index    'set node number
                End If
            End If
        Next
        'Level 3
        For Each Row As DataRow In MyTable.Rows    'Walk through the datatable one record at a time
            CatCode = Row("CatCode").ToString
            CatName = Row("CatName").ToString
            If FindNode(TreeView1.Nodes, Row("Level1").ToString, oNode) Then        ' Find level one node - it must exist as this is level 3
                a1 = oNode.Index    'set node number
            End If
            If FindNode(TreeView1.Nodes, Row("Level2").ToString, oNode) Then        ' Find level 2 node - it must exist as this is level 3
                b1 = oNode.Index    'set node number
            End If
            If Not FindNode(TreeView1.Nodes, Row("Level3").ToString, oNode) Then
                If Row("Level3").ToString <> "" Then TreeView1.Nodes(0).Nodes(a1).Nodes(b1).Nodes.Add(New TreeNode(Row("Level3").ToString)) ' node not found so add it
            Else
                c1 = oNode.Index    'set node number
            End If
        Next
jump:
        b1 = 0
        c1 = 0
        TreeView1.ExpandAll()
    End Sub

    Private Sub btnFindNode_Click(sender As System.Object, e As System.EventArgs) Handles btnFindNode.Click
        Dim oNode As TreeNode = New TreeNode
        Dim result As Boolean

        result = FindNode(TreeView1.Nodes, "Networking", oNode)
        MsgBox(result & " " & oNode.Index)
    End Sub
    Private Function FindNode(ByVal oNodes As TreeNodeCollection, ByVal sTag As String, ByRef oNode As TreeNode)
        Dim node As TreeNode
        Dim result As Boolean = False

        For Each node In oNodes
            If node.Text = sTag Then
                oNode = node
                Return (True)
            End If
            If node.Nodes.Count > 0 Then
                If FindNode(node.Nodes, sTag, oNode) Then
                    Return (True)
                End If
            End If
        Next
        Return (False)
    End Function
End Class