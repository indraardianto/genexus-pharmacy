using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "ProductType" )]
   [XmlType(TypeName =  "ProductType" , Namespace = "Pharmacy" )]
   [Serializable]
   public class SdtProductType : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtProductType( )
      {
      }

      public SdtProductType( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override string JsonMap( string value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (string)mapper[value]; ;
      }

      public void Load( short AV5ProductTypeCode )
      {
         IGxSilentTrn obj;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV5ProductTypeCode});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"ProductTypeCode", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties();
         metadata.Set("Name", "ProductType");
         metadata.Set("BT", "ProductType");
         metadata.Set("PK", "[ \"ProductTypeCode\" ]");
         metadata.Set("PKAssigned", "[ \"ProductTypeCode\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection();
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Producttypecode_Z");
         state.Add("gxTpr_Producttypename_Z");
         state.Add("gxTpr_Producttypeproductquantity_Z");
         state.Add("gxTpr_Producttypeproductquantity_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtProductType sdt;
         sdt = (SdtProductType)(source);
         gxTv_SdtProductType_Producttypecode = sdt.gxTv_SdtProductType_Producttypecode ;
         gxTv_SdtProductType_Producttypename = sdt.gxTv_SdtProductType_Producttypename ;
         gxTv_SdtProductType_Producttypeproductquantity = sdt.gxTv_SdtProductType_Producttypeproductquantity ;
         gxTv_SdtProductType_Mode = sdt.gxTv_SdtProductType_Mode ;
         gxTv_SdtProductType_Initialized = sdt.gxTv_SdtProductType_Initialized ;
         gxTv_SdtProductType_Producttypecode_Z = sdt.gxTv_SdtProductType_Producttypecode_Z ;
         gxTv_SdtProductType_Producttypename_Z = sdt.gxTv_SdtProductType_Producttypename_Z ;
         gxTv_SdtProductType_Producttypeproductquantity_Z = sdt.gxTv_SdtProductType_Producttypeproductquantity_Z ;
         gxTv_SdtProductType_Producttypeproductquantity_N = sdt.gxTv_SdtProductType_Producttypeproductquantity_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         ToJSON( includeState, true) ;
         return  ;
      }

      public override void ToJSON( bool includeState ,
                                   bool includeNonInitialized )
      {
         AddObjectProperty("ProductTypeCode", gxTv_SdtProductType_Producttypecode, false, includeNonInitialized);
         AddObjectProperty("ProductTypeName", gxTv_SdtProductType_Producttypename, false, includeNonInitialized);
         AddObjectProperty("ProductTypeProductQuantity", gxTv_SdtProductType_Producttypeproductquantity, false, includeNonInitialized);
         AddObjectProperty("ProductTypeProductQuantity_N", gxTv_SdtProductType_Producttypeproductquantity_N, false, includeNonInitialized);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtProductType_Mode, false, includeNonInitialized);
            AddObjectProperty("Initialized", gxTv_SdtProductType_Initialized, false, includeNonInitialized);
            AddObjectProperty("ProductTypeCode_Z", gxTv_SdtProductType_Producttypecode_Z, false, includeNonInitialized);
            AddObjectProperty("ProductTypeName_Z", gxTv_SdtProductType_Producttypename_Z, false, includeNonInitialized);
            AddObjectProperty("ProductTypeProductQuantity_Z", gxTv_SdtProductType_Producttypeproductquantity_Z, false, includeNonInitialized);
            AddObjectProperty("ProductTypeProductQuantity_N", gxTv_SdtProductType_Producttypeproductquantity_N, false, includeNonInitialized);
         }
         return  ;
      }

      public void UpdateDirties( SdtProductType sdt )
      {
         if ( sdt.IsDirty("ProductTypeCode") )
         {
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Producttypecode = sdt.gxTv_SdtProductType_Producttypecode ;
         }
         if ( sdt.IsDirty("ProductTypeName") )
         {
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Producttypename = sdt.gxTv_SdtProductType_Producttypename ;
         }
         if ( sdt.IsDirty("ProductTypeProductQuantity") )
         {
            gxTv_SdtProductType_Producttypeproductquantity_N = 0;
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Producttypeproductquantity = sdt.gxTv_SdtProductType_Producttypeproductquantity ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "ProductTypeCode" )]
      [  XmlElement( ElementName = "ProductTypeCode"   )]
      public short gxTpr_Producttypecode
      {
         get {
            return gxTv_SdtProductType_Producttypecode ;
         }

         set {
            gxTv_SdtProductType_N = 0;
            if ( gxTv_SdtProductType_Producttypecode != value )
            {
               gxTv_SdtProductType_Mode = "INS";
               this.gxTv_SdtProductType_Producttypecode_Z_SetNull( );
               this.gxTv_SdtProductType_Producttypename_Z_SetNull( );
               this.gxTv_SdtProductType_Producttypeproductquantity_Z_SetNull( );
            }
            gxTv_SdtProductType_Producttypecode = value;
            SetDirty("Producttypecode");
         }

      }

      [  SoapElement( ElementName = "ProductTypeName" )]
      [  XmlElement( ElementName = "ProductTypeName"   )]
      public string gxTpr_Producttypename
      {
         get {
            return gxTv_SdtProductType_Producttypename ;
         }

         set {
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Producttypename = value;
            SetDirty("Producttypename");
         }

      }

      [  SoapElement( ElementName = "ProductTypeProductQuantity" )]
      [  XmlElement( ElementName = "ProductTypeProductQuantity"   )]
      public int gxTpr_Producttypeproductquantity
      {
         get {
            return gxTv_SdtProductType_Producttypeproductquantity ;
         }

         set {
            gxTv_SdtProductType_Producttypeproductquantity_N = 0;
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Producttypeproductquantity = value;
            SetDirty("Producttypeproductquantity");
         }

      }

      public void gxTv_SdtProductType_Producttypeproductquantity_SetNull( )
      {
         gxTv_SdtProductType_Producttypeproductquantity_N = 1;
         gxTv_SdtProductType_Producttypeproductquantity = 0;
         return  ;
      }

      public bool gxTv_SdtProductType_Producttypeproductquantity_IsNull( )
      {
         return (gxTv_SdtProductType_Producttypeproductquantity_N==1) ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public string gxTpr_Mode
      {
         get {
            return gxTv_SdtProductType_Mode ;
         }

         set {
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtProductType_Mode_SetNull( )
      {
         gxTv_SdtProductType_Mode = "";
         return  ;
      }

      public bool gxTv_SdtProductType_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtProductType_Initialized ;
         }

         set {
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtProductType_Initialized_SetNull( )
      {
         gxTv_SdtProductType_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtProductType_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProductTypeCode_Z" )]
      [  XmlElement( ElementName = "ProductTypeCode_Z"   )]
      public short gxTpr_Producttypecode_Z
      {
         get {
            return gxTv_SdtProductType_Producttypecode_Z ;
         }

         set {
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Producttypecode_Z = value;
            SetDirty("Producttypecode_Z");
         }

      }

      public void gxTv_SdtProductType_Producttypecode_Z_SetNull( )
      {
         gxTv_SdtProductType_Producttypecode_Z = 0;
         return  ;
      }

      public bool gxTv_SdtProductType_Producttypecode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProductTypeName_Z" )]
      [  XmlElement( ElementName = "ProductTypeName_Z"   )]
      public string gxTpr_Producttypename_Z
      {
         get {
            return gxTv_SdtProductType_Producttypename_Z ;
         }

         set {
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Producttypename_Z = value;
            SetDirty("Producttypename_Z");
         }

      }

      public void gxTv_SdtProductType_Producttypename_Z_SetNull( )
      {
         gxTv_SdtProductType_Producttypename_Z = "";
         return  ;
      }

      public bool gxTv_SdtProductType_Producttypename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProductTypeProductQuantity_Z" )]
      [  XmlElement( ElementName = "ProductTypeProductQuantity_Z"   )]
      public int gxTpr_Producttypeproductquantity_Z
      {
         get {
            return gxTv_SdtProductType_Producttypeproductquantity_Z ;
         }

         set {
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Producttypeproductquantity_Z = value;
            SetDirty("Producttypeproductquantity_Z");
         }

      }

      public void gxTv_SdtProductType_Producttypeproductquantity_Z_SetNull( )
      {
         gxTv_SdtProductType_Producttypeproductquantity_Z = 0;
         return  ;
      }

      public bool gxTv_SdtProductType_Producttypeproductquantity_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProductTypeProductQuantity_N" )]
      [  XmlElement( ElementName = "ProductTypeProductQuantity_N"   )]
      public short gxTpr_Producttypeproductquantity_N
      {
         get {
            return gxTv_SdtProductType_Producttypeproductquantity_N ;
         }

         set {
            gxTv_SdtProductType_N = 0;
            gxTv_SdtProductType_Producttypeproductquantity_N = value;
            SetDirty("Producttypeproductquantity_N");
         }

      }

      public void gxTv_SdtProductType_Producttypeproductquantity_N_SetNull( )
      {
         gxTv_SdtProductType_Producttypeproductquantity_N = 0;
         return  ;
      }

      public bool gxTv_SdtProductType_Producttypeproductquantity_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtProductType_N = 1;
         gxTv_SdtProductType_Producttypename = "";
         gxTv_SdtProductType_Mode = "";
         gxTv_SdtProductType_Producttypename_Z = "";
         IGxSilentTrn obj;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "producttype", "GeneXus.Programs.producttype_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      public short isNull( )
      {
         return gxTv_SdtProductType_N ;
      }

      private short gxTv_SdtProductType_Producttypecode ;
      private short gxTv_SdtProductType_N ;
      private short gxTv_SdtProductType_Initialized ;
      private short gxTv_SdtProductType_Producttypecode_Z ;
      private short gxTv_SdtProductType_Producttypeproductquantity_N ;
      private int gxTv_SdtProductType_Producttypeproductquantity ;
      private int gxTv_SdtProductType_Producttypeproductquantity_Z ;
      private string gxTv_SdtProductType_Producttypename ;
      private string gxTv_SdtProductType_Mode ;
      private string gxTv_SdtProductType_Producttypename_Z ;
   }

   [DataContract(Name = @"ProductType", Namespace = "Pharmacy")]
   public class SdtProductType_RESTInterface : GxGenericCollectionItem<SdtProductType>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtProductType_RESTInterface( ) : base()
      {
      }

      public SdtProductType_RESTInterface( SdtProductType psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ProductTypeCode" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Producttypecode
      {
         get {
            return sdt.gxTpr_Producttypecode ;
         }

         set {
            sdt.gxTpr_Producttypecode = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "ProductTypeName" , Order = 1 )]
      [GxSeudo()]
      public string gxTpr_Producttypename
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Producttypename) ;
         }

         set {
            sdt.gxTpr_Producttypename = value;
         }

      }

      [DataMember( Name = "ProductTypeProductQuantity" , Order = 2 )]
      [GxSeudo()]
      public string gxTpr_Producttypeproductquantity
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Producttypeproductquantity), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Producttypeproductquantity = (int)(NumberUtil.Val( value, "."));
         }

      }

      public SdtProductType sdt
      {
         get {
            return (SdtProductType)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtProductType() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 3 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (string)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private string md5Hash ;
   }

   [DataContract(Name = @"ProductType", Namespace = "Pharmacy")]
   public class SdtProductType_RESTLInterface : GxGenericCollectionItem<SdtProductType>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtProductType_RESTLInterface( ) : base()
      {
      }

      public SdtProductType_RESTLInterface( SdtProductType psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ProductTypeName" , Order = 0 )]
      [GxSeudo()]
      public string gxTpr_Producttypename
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Producttypename) ;
         }

         set {
            sdt.gxTpr_Producttypename = value;
         }

      }

      [DataMember( Name = "uri", Order = 1 )]
      public string Uri
      {
         get {
            return "" ;
         }

         set {
         }

      }

      public SdtProductType sdt
      {
         get {
            return (SdtProductType)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtProductType() ;
         }
      }

   }

}
