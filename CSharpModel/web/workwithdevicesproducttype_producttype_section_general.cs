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
   public class workwithdevicesproducttype_producttype_section_general : GXProcedure
   {
      public workwithdevicesproducttype_producttype_section_general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesproducttype_producttype_section_general( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void execute( short aP0_ProductTypeCode ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt aP2_GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt )
      {
         this.A5ProductTypeCode = aP0_ProductTypeCode;
         this.AV6gxid = aP1_gxid;
         this.AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt = new SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt=this.AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt;
      }

      public SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt executeUdp( short aP0_ProductTypeCode ,
                                                                                      int aP1_gxid )
      {
         execute(aP0_ProductTypeCode, aP1_gxid, out aP2_GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt);
         return AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt ;
      }

      public void executeSubmit( short aP0_ProductTypeCode ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt aP2_GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt )
      {
         workwithdevicesproducttype_producttype_section_general objworkwithdevicesproducttype_producttype_section_general;
         objworkwithdevicesproducttype_producttype_section_general = new workwithdevicesproducttype_producttype_section_general();
         objworkwithdevicesproducttype_producttype_section_general.A5ProductTypeCode = aP0_ProductTypeCode;
         objworkwithdevicesproducttype_producttype_section_general.AV6gxid = aP1_gxid;
         objworkwithdevicesproducttype_producttype_section_general.AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt = new SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt(context) ;
         objworkwithdevicesproducttype_producttype_section_general.context.SetSubmitInitialConfig(context);
         objworkwithdevicesproducttype_producttype_section_general.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesproducttype_producttype_section_general);
         aP2_GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt=this.AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesproducttype_producttype_section_general)stateInfo).executePrivate();
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
         /* Using cursor P00003 */
         pr_default.execute(0, new Object[] {A5ProductTypeCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A6ProductTypeName = P00003_A6ProductTypeName[0];
            A8ProductTypeProductQuantity = P00003_A8ProductTypeProductQuantity[0];
            n8ProductTypeProductQuantity = P00003_n8ProductTypeProductQuantity[0];
            A8ProductTypeProductQuantity = P00003_A8ProductTypeProductQuantity[0];
            n8ProductTypeProductQuantity = P00003_n8ProductTypeProductQuantity[0];
            AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt.gxTpr_Producttypecode = A5ProductTypeCode;
            AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt.gxTpr_Producttypename = A6ProductTypeName;
            AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt.gxTpr_Producttypeproductquantity = A8ProductTypeProductQuantity;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
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
         AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt = new SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt(context);
         scmdbuf = "";
         P00003_A5ProductTypeCode = new short[1] ;
         P00003_A6ProductTypeName = new string[] {""} ;
         P00003_A8ProductTypeProductQuantity = new int[1] ;
         P00003_n8ProductTypeProductQuantity = new bool[] {false} ;
         A6ProductTypeName = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesproducttype_producttype_section_general__default(),
            new Object[][] {
                new Object[] {
               P00003_A5ProductTypeCode, P00003_A6ProductTypeName, P00003_A8ProductTypeProductQuantity, P00003_n8ProductTypeProductQuantity
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A5ProductTypeCode ;
      private int AV6gxid ;
      private int A8ProductTypeProductQuantity ;
      private string scmdbuf ;
      private string A6ProductTypeName ;
      private bool n8ProductTypeProductQuantity ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00003_A5ProductTypeCode ;
      private string[] P00003_A6ProductTypeName ;
      private int[] P00003_A8ProductTypeProductQuantity ;
      private bool[] P00003_n8ProductTypeProductQuantity ;
      private SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt aP2_GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt ;
      private SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt AV7GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt ;
   }

   public class workwithdevicesproducttype_producttype_section_general__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00003;
          prmP00003 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          def= new CursorDef[] {
              new CursorDef("P00003", "SELECT TOP 1 T1.[ProductTypeCode], T1.[ProductTypeName], COALESCE( T2.[ProductTypeProductQuantity], 0) AS ProductTypeProductQuantity FROM ([ProductType] T1 LEFT JOIN (SELECT COUNT(*) AS ProductTypeProductQuantity, [ProductTypeCode] FROM [Product] GROUP BY [ProductTypeCode] ) T2 ON T2.[ProductTypeCode] = T1.[ProductTypeCode]) WHERE T1.[ProductTypeCode] = @ProductTypeCode ORDER BY T1.[ProductTypeCode] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00003,1, GxCacheFrequency.OFF ,false,true )
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
                ((string[]) buf[1])[0] = rslt.getString(2, 50);
                ((int[]) buf[2])[0] = rslt.getInt(3);
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesproducttype_producttype_section_general_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesproducttype_producttype_section_general_services : GxRestService
 {
    [OperationContract(Name = "WorkWithDevicesProductType_ProductType_Section_General" )]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?ProductTypeCode={ProductTypeCode}&gxid={gxid}")]
    public SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_RESTInterface execute( short ProductTypeCode ,
                                                                                               string gxid )
    {
       SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_RESTInterface GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt = new SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_RESTInterface();
       try
       {
          if ( ! ProcessHeaders("workwithdevicesproducttype_producttype_section_general") )
          {
             return null ;
          }
          workwithdevicesproducttype_producttype_section_general worker = new workwithdevicesproducttype_producttype_section_general(context);
          worker.IsMain = RunAsMain ;
          int gxrgxid = 0;
          gxrgxid = (int)(NumberUtil.Val( (string)(gxid), "."));
          SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt gxrGXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt = GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt.sdt;
          worker.execute(ProductTypeCode,gxrgxid,out gxrGXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt );
          worker.cleanup( );
          GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt = new SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_RESTInterface(gxrGXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt) ;
          return GXM1WorkWithDevicesProductType_ProductType_Section_GeneralSdt ;
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
