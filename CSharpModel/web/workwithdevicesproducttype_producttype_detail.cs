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
   public class workwithdevicesproducttype_producttype_detail : GXProcedure
   {
      public workwithdevicesproducttype_producttype_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesproducttype_producttype_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void execute( short aP0_ProductTypeCode ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesProductType_ProductType_DetailSdt aP2_GXM2WorkWithDevicesProductType_ProductType_DetailSdt )
      {
         this.A5ProductTypeCode = aP0_ProductTypeCode;
         this.AV6gxid = aP1_gxid;
         this.AV11GXM2WorkWithDevicesProductType_ProductType_DetailSdt = new SdtWorkWithDevicesProductType_ProductType_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesProductType_ProductType_DetailSdt=this.AV11GXM2WorkWithDevicesProductType_ProductType_DetailSdt;
      }

      public SdtWorkWithDevicesProductType_ProductType_DetailSdt executeUdp( short aP0_ProductTypeCode ,
                                                                             int aP1_gxid )
      {
         execute(aP0_ProductTypeCode, aP1_gxid, out aP2_GXM2WorkWithDevicesProductType_ProductType_DetailSdt);
         return AV11GXM2WorkWithDevicesProductType_ProductType_DetailSdt ;
      }

      public void executeSubmit( short aP0_ProductTypeCode ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesProductType_ProductType_DetailSdt aP2_GXM2WorkWithDevicesProductType_ProductType_DetailSdt )
      {
         workwithdevicesproducttype_producttype_detail objworkwithdevicesproducttype_producttype_detail;
         objworkwithdevicesproducttype_producttype_detail = new workwithdevicesproducttype_producttype_detail();
         objworkwithdevicesproducttype_producttype_detail.A5ProductTypeCode = aP0_ProductTypeCode;
         objworkwithdevicesproducttype_producttype_detail.AV6gxid = aP1_gxid;
         objworkwithdevicesproducttype_producttype_detail.AV11GXM2WorkWithDevicesProductType_ProductType_DetailSdt = new SdtWorkWithDevicesProductType_ProductType_DetailSdt(context) ;
         objworkwithdevicesproducttype_producttype_detail.context.SetSubmitInitialConfig(context);
         objworkwithdevicesproducttype_producttype_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesproducttype_producttype_detail);
         aP2_GXM2WorkWithDevicesProductType_ProductType_DetailSdt=this.AV11GXM2WorkWithDevicesProductType_ProductType_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesproducttype_producttype_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV6gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            /* Using cursor P00002 */
            pr_default.execute(0, new Object[] {A5ProductTypeCode});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A6ProductTypeName = P00002_A6ProductTypeName[0];
               Gxdynprop1 = A6ProductTypeName;
               Gxdynprop += ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            Gxwebsession.Set(Gxids, "true");
         }
         AV11GXM2WorkWithDevicesProductType_ProductType_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
         Gxdynprop = "";
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
         AV11GXM2WorkWithDevicesProductType_ProductType_DetailSdt = new SdtWorkWithDevicesProductType_ProductType_DetailSdt(context);
         Gxids = "";
         Gxwebsession = context.GetSession();
         scmdbuf = "";
         P00002_A5ProductTypeCode = new short[1] ;
         P00002_A6ProductTypeName = new string[] {""} ;
         A6ProductTypeName = "";
         Gxdynprop1 = "";
         Gxdynprop = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesproducttype_producttype_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A5ProductTypeCode, P00002_A6ProductTypeName
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A5ProductTypeCode ;
      private int AV6gxid ;
      private string Gxids ;
      private string scmdbuf ;
      private string A6ProductTypeName ;
      private string Gxdynprop1 ;
      private string Gxdynprop ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00002_A5ProductTypeCode ;
      private string[] P00002_A6ProductTypeName ;
      private SdtWorkWithDevicesProductType_ProductType_DetailSdt aP2_GXM2WorkWithDevicesProductType_ProductType_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesProductType_ProductType_DetailSdt AV11GXM2WorkWithDevicesProductType_ProductType_DetailSdt ;
   }

   public class workwithdevicesproducttype_producttype_detail__default : DataStoreHelperBase, IDataStoreHelper
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
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [ProductTypeCode], [ProductTypeName] FROM [ProductType] WHERE [ProductTypeCode] = @ProductTypeCode ORDER BY [ProductTypeCode] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1, GxCacheFrequency.OFF ,false,true )
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
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesproducttype_producttype_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesproducttype_producttype_detail_services : GxRestService
 {
    [OperationContract(Name = "WorkWithDevicesProductType_ProductType_Detail" )]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?ProductTypeCode={ProductTypeCode}&gxid={gxid}")]
    public SdtWorkWithDevicesProductType_ProductType_DetailSdt_RESTInterface execute( short ProductTypeCode ,
                                                                                      string gxid )
    {
       SdtWorkWithDevicesProductType_ProductType_DetailSdt_RESTInterface GXM2WorkWithDevicesProductType_ProductType_DetailSdt = new SdtWorkWithDevicesProductType_ProductType_DetailSdt_RESTInterface();
       try
       {
          if ( ! ProcessHeaders("workwithdevicesproducttype_producttype_detail") )
          {
             return null ;
          }
          workwithdevicesproducttype_producttype_detail worker = new workwithdevicesproducttype_producttype_detail(context);
          worker.IsMain = RunAsMain ;
          int gxrgxid = 0;
          gxrgxid = (int)(NumberUtil.Val( (string)(gxid), "."));
          SdtWorkWithDevicesProductType_ProductType_DetailSdt gxrGXM2WorkWithDevicesProductType_ProductType_DetailSdt = GXM2WorkWithDevicesProductType_ProductType_DetailSdt.sdt;
          worker.execute(ProductTypeCode,gxrgxid,out gxrGXM2WorkWithDevicesProductType_ProductType_DetailSdt );
          worker.cleanup( );
          GXM2WorkWithDevicesProductType_ProductType_DetailSdt = new SdtWorkWithDevicesProductType_ProductType_DetailSdt_RESTInterface(gxrGXM2WorkWithDevicesProductType_ProductType_DetailSdt) ;
          return GXM2WorkWithDevicesProductType_ProductType_DetailSdt ;
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
