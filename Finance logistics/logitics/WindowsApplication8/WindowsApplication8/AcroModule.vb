Imports System.Data.SqlClient


Module AcroModule

    Public Function connString()
        Dim str As String

        'str = "Data Source= LAPTOP-FOHM0ANH,34458;Network Library= DBMSSOCN;User id=sa;Password=201311422;Initial Catalog=AcroDistributionNetworkInc;Integrated Security=False"

        str = "Data Source=LAPTOP-KQ07UHHG;Initial Catalog=AcroDistributionNetworkInc;User ID=sa;Password=ronerick123;MultipleActiveResultSets=True"

        Return str

    End Function


End Module
