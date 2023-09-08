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
   public class workwithdevicesproducttype_producttype_list_grid1 : GXProcedure
   {
      public workwithdevicesproducttype_producttype_list_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesproducttype_producttype_list_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void execute( string aP0_SearchText ,
                           long aP1_start ,
                           long aP2_count ,
                           int aP3_gxid ,
                           out GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         this.AV8SearchText = aP0_SearchText;
         this.AV6start = aP1_start;
         this.AV7count = aP2_count;
         this.AV5gxid = aP3_gxid;
         this.AV9GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item>( context, "WorkWithDevicesProductType_ProductType_List_Grid1Sdt.Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV9GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item> executeUdp( string aP0_SearchText ,
                                                                                                        long aP1_start ,
                                                                                                        long aP2_count ,
                                                                                                        int aP3_gxid )
      {
         execute(aP0_SearchText, aP1_start, aP2_count, aP3_gxid, out aP4_GXM2RootCol);
         return AV9GXM2RootCol ;
      }

      public void executeSubmit( string aP0_SearchText ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         workwithdevicesproducttype_producttype_list_grid1 objworkwithdevicesproducttype_producttype_list_grid1;
         objworkwithdevicesproducttype_producttype_list_grid1 = new workwithdevicesproducttype_producttype_list_grid1();
         objworkwithdevicesproducttype_producttype_list_grid1.AV8SearchText = aP0_SearchText;
         objworkwithdevicesproducttype_producttype_list_grid1.AV6start = aP1_start;
         objworkwithdevicesproducttype_producttype_list_grid1.AV7count = aP2_count;
         objworkwithdevicesproducttype_producttype_list_grid1.AV5gxid = aP3_gxid;
         objworkwithdevicesproducttype_producttype_list_grid1.AV9GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item>( context, "WorkWithDevicesProductType_ProductType_List_Grid1Sdt.Item", "") ;
         objworkwithdevicesproducttype_producttype_list_grid1.context.SetSubmitInitialConfig(context);
         objworkwithdevicesproducttype_producttype_list_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesproducttype_producttype_list_grid1);
         aP4_GXM2RootCol=this.AV9GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesproducttype_producttype_list_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV6start);
         GXPagingTo2 = (int)(AV7count);
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV8SearchText ,
                                              A6ProductTypeName } ,
                                              new int[]{
                                              }
         });
         lV8SearchText = StringUtil.Concat( StringUtil.RTrim( AV8SearchText), "%", "");
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {lV8SearchText, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A6ProductTypeName = P00002_A6ProductTypeName[0];
            A5ProductTypeCode = P00002_A5ProductTypeCode[0];
            AV10GXM1WorkWithDevicesProductType_ProductType_List_Grid1Sdt = new SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item(context);
            AV9GXM2RootCol.Add(AV10GXM1WorkWithDevicesProductType_ProductType_List_Grid1Sdt, 0);
            AV10GXM1WorkWithDevicesProductType_ProductType_List_Grid1Sdt.gxTpr_Producttypecode = A5ProductTypeCode;
            AV10GXM1WorkWithDevicesProductType_ProductType_List_Grid1Sdt.gxTpr_Producttypename = A6ProductTypeName;
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
         AV9GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item>( context, "WorkWithDevicesProductType_ProductType_List_Grid1Sdt.Item", "");
         scmdbuf = "";
         lV8SearchText = "";
         A6ProductTypeName = "";
         P00002_A6ProductTypeName = new string[] {""} ;
         P00002_A5ProductTypeCode = new short[1] ;
         AV10GXM1WorkWithDevicesProductType_ProductType_List_Grid1Sdt = new SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesproducttype_producttype_list_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A6ProductTypeName, P00002_A5ProductTypeCode
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A5ProductTypeCode ;
      private int AV5gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV6start ;
      private long AV7count ;
      private string scmdbuf ;
      private string A6ProductTypeName ;
      private string AV8SearchText ;
      private string lV8SearchText ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private string[] P00002_A6ProductTypeName ;
      private short[] P00002_A5ProductTypeCode ;
      private GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item> aP4_GXM2RootCol ;
      private GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item> AV9GXM2RootCol ;
      private SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item AV10GXM1WorkWithDevicesProductType_ProductType_List_Grid1Sdt ;
   }

   public class workwithdevicesproducttype_producttype_list_grid1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00002( IGxContext context ,
                                             string AV8SearchText ,
                                             string A6ProductTypeName )
      {
         System.Text.StringBuilder sWhereString = new System.Text.StringBuilder();
         string scmdbuf;
         short[] GXv_int1 = new short[4];
         Object[] GXv_Object2 = new Object[2];
         string sSelectString;
         string sFromString;
         string sOrderString;
         sSelectString = " [ProductTypeName], [ProductTypeCode]";
         sFromString = " FROM [ProductType]";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8SearchText)) )
         {
            AddWhere(sWhereString, "(UPPER([ProductTypeName]) like '%' + UPPER(@lV8SearchText))");
         }
         else
         {
            GXv_int1[0] = 1;
         }
         sOrderString += " ORDER BY [ProductTypeName]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00002(context, (string)dynConstraints[0] , (string)dynConstraints[1] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          new ParDef("@lV8SearchText",GXType.VarChar,1000,0) ,
          new ParDef("@GXPagingFrom2",GXType.Int32,9,0) ,
          new ParDef("@GXPagingTo2",GXType.Int32,9,0) ,
          new ParDef("@GXPagingTo2",GXType.Int32,9,0)
          };
          def= new CursorDef[] {
              new CursorDef("P00002", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100, GxCacheFrequency.OFF ,false,false )
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
                ((string[]) buf[0])[0] = rslt.getString(1, 50);
                ((short[]) buf[1])[0] = rslt.getShort(2);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesproducttype_producttype_list_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesproducttype_producttype_list_grid1_services : GxRestService
 {
    [OperationContract(Name = "WorkWithDevicesProductType_ProductType_List_Grid1" )]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?SearchText={SearchText}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item_RESTInterface> execute( string SearchText ,
                                                                                                                    string start ,
                                                                                                                    string count ,
                                                                                                                    string gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item_RESTInterface>();
       try
       {
          if ( ! ProcessHeaders("workwithdevicesproducttype_producttype_list_grid1") )
          {
             return null ;
          }
          workwithdevicesproducttype_producttype_list_grid1 worker = new workwithdevicesproducttype_producttype_list_grid1(context);
          worker.IsMain = RunAsMain ;
          long gxrstart = 0;
          gxrstart = (long)(NumberUtil.Val( (string)(start), "."));
          long gxrcount = 0;
          gxrcount = (long)(NumberUtil.Val( (string)(count), "."));
          int gxrgxid = 0;
          gxrgxid = (int)(NumberUtil.Val( (string)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item>();
          worker.execute(SearchText,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesProductType_ProductType_List_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
