Module MaintenanceModule


    Public Function connstring()

        Dim str As String

        'str = "Data Source=LAPTOP-FOHM0ANH,34458;Network Library=DBMSSOCN;Initial Catalog=AcroDistributionNetworkInc;User id=sa;Password=201311422;Integrated Security=False;MultipleActiveResultSets=True"

        'str = "Data Source=LAPTOP-KQ07UHHG;Initial Catalog=AcroDistributionNetworkInc;User ID=sa;Password=ronerick123;MultipleActiveResultSets=True"

        str = "Data Source=PRINCESSBELLE\SQLEXPRESS;Initial Catalog=AcroDistributionNetworkInc;User ID=sa;Password=ronerick123;MultipleActiveResultSets=True"


        Return str


    End Function
End Module

