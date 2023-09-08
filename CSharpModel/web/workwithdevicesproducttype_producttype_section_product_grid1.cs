using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class workwithdevicesproducttype_producttype_section_product_grid1 : GXProcedure
   {
      public workwithdevicesproducttype_producttype_section_product_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesproducttype_producttype_section_product_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void execute( short aP0_ProductTypeCode ,
                           long aP1_start ,
                           long aP2_count ,
                           int aP3_gxid ,
                           out GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         this.A5ProductTypeCode = aP0_ProductTypeCode;
         this.AV7start = aP1_start;
         this.AV8count = aP2_count;
         this.AV6gxid = aP3_gxid;
         this.AV9GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item>( context, "WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt.Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV9GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item> executeUdp( short aP0_ProductTypeCode ,
                                                                                                                   long aP1_start ,
                                                                                                                   long aP2_count ,
                                                                                                                   int aP3_gxid )
      {
         execute(aP0_ProductTypeCode, aP1_start, aP2_count, aP3_gxid, out aP4_GXM2RootCol);
         return AV9GXM2RootCol ;
      }

      public void executeSubmit( short aP0_ProductTypeCode ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         workwithdevicesproducttype_producttype_section_product_grid1 objworkwithdevicesproducttype_producttype_section_product_grid1;
         objworkwithdevicesproducttype_producttype_section_product_grid1 = new workwithdevicesproducttype_producttype_section_product_grid1();
         objworkwithdevicesproducttype_producttype_section_product_grid1.A5ProductTypeCode = aP0_ProductTypeCode;
         objworkwithdevicesproducttype_producttype_section_product_grid1.AV7start = aP1_start;
         objworkwithdevicesproducttype_producttype_section_product_grid1.AV8count = aP2_count;
         objworkwithdevicesproducttype_producttype_section_product_grid1.AV6gxid = aP3_gxid;
         objworkwithdevicesproducttype_producttype_section_product_grid1.AV9GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item>( context, "WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt.Item", "") ;
         objworkwithdevicesproducttype_producttype_section_product_grid1.context.SetSubmitInitialConfig(context);
         objworkwithdevicesproducttype_producttype_section_product_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesproducttype_producttype_section_product_grid1);
         aP4_GXM2RootCol=this.AV9GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesproducttype_producttype_section_product_grid1)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         GXPagingFrom2 = (int)(AV7start);
         GXPagingTo2 = (int)(AV8count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {A5ProductTypeCode, GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A40000ProductPhoto_GXI = P00002_A40000ProductPhoto_GXI[0];
            A1ProductCode = P00002_A1ProductCode[0];
            A2ProductName = P00002_A2ProductName[0];
            A7ProductPhoto = P00002_A7ProductPhoto[0];
            AV10GXM1WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt = new SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item(context);
            AV9GXM2RootCol.Add(AV10GXM1WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt, 0);
            AV10GXM1WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt.gxTpr_Productcode = A1ProductCode;
            AV10GXM1WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt.gxTpr_Productphoto = A7ProductPhoto;
            AV10GXM1WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt.gxTpr_Productphoto_gxi = A40000ProductPhoto_GXI;
            AV10GXM1WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt.gxTpr_Productname = A2ProductName;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections();
         }
         ExitApp();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV9GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item>( context, "WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt.Item", "");
         scmdbuf = "";
         P00002_A5ProductTypeCode = new short[1] ;
         P00002_A40000ProductPhoto_GXI = new string[] {""} ;
         P00002_A1ProductCode = new short[1] ;
         P00002_A2ProductName = new string[] {""} ;
         P00002_A7ProductPhoto = new string[] {""} ;
         A40000ProductPhoto_GXI = "";
         A2ProductName = "";
         A7ProductPhoto = "";
         AV10GXM1WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt = new SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesproducttype_producttype_section_product_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A5ProductTypeCode, P00002_A40000ProductPhoto_GXI, P00002_A1ProductCode, P00002_A2ProductName, P00002_A7ProductPhoto
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A5ProductTypeCode ;
      private short A1ProductCode ;
      private int AV6gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV7start ;
      private long AV8count ;
      private string scmdbuf ;
      private string A2ProductName ;
      private string A40000ProductPhoto_GXI ;
      private string A7ProductPhoto ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00002_A5ProductTypeCode ;
      private string[] P00002_A40000ProductPhoto_GXI ;
      private short[] P00002_A1ProductCode ;
      private string[] P00002_A2ProductName ;
      private string[] P00002_A7ProductPhoto ;
      private GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item> aP4_GXM2RootCol ;
      private GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item> AV9GXM2RootCol ;
      private SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item AV10GXM1WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt ;
   }

   public class workwithdevicesproducttype_producttype_section_product_grid1__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00002;
          prmP00002 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0) ,
          new ParDef("@GXPagingFrom2",GXType.Int32,9,0) ,
          new ParDef("@GXPagingTo2",GXType.Int32,9,0)
          };
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [ProductTypeCode], [ProductPhoto_GXI], [ProductCode], [ProductName], [ProductPhoto] FROM [Product] WHERE [ProductTypeCode] = @ProductTypeCode ORDER BY [ProductTypeCode]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100, GxCacheFrequency.OFF ,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getMultimediaUri(2);
                ((short[]) buf[2])[0] = rslt.getShort(3);
                ((string[]) buf[3])[0] = rslt.getString(4, 50);
                ((string[]) buf[4])[0] = rslt.getMultimediaFile(5, rslt.getVarchar(2));
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesproducttype_producttype_section_product_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesproducttype_producttype_section_product_grid1_services : GxRestService
 {
    [OperationContract(Name = "WorkWithDevicesProductType_ProductType_Section_Product_Grid1" )]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?ProductTypeCode={ProductTypeCode}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_RESTInterface> execute( short ProductTypeCode ,
                                                                                                                               string start ,
                                                                                                                               string count ,
                                                                                                                               string gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_RESTInterface>();
       try
       {
          if ( ! ProcessHeaders("workwithdevicesproducttype_producttype_section_product_grid1") )
          {
             return null ;
          }
          workwithdevicesproducttype_producttype_section_product_grid1 worker = new workwithdevicesproducttype_producttype_section_product_grid1(context);
          worker.IsMain = RunAsMain ;
          long gxrstart = 0;
          gxrstart = (long)(NumberUtil.Val( (string)(start), "."));
          long gxrcount = 0;
          gxrcount = (long)(NumberUtil.Val( (string)(count), "."));
          int gxrgxid = 0;
          gxrgxid = (int)(NumberUtil.Val( (string)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item>();
          worker.execute(ProductTypeCode,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
          return GXM2RootCol ;
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
       return null ;
    }

 }

}
