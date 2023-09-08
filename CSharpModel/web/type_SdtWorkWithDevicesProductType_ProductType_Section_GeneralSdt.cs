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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "WorkWithDevicesProductType_ProductType_Section_GeneralSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesProductType_ProductType_Section_GeneralSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt : GxUserType
   {
      public SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypename = "";
      }

      public SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt( IGxContext context )
      {
         this.context = context;
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
         AddObjectProperty("ProductTypeCode", gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypecode, false, false);
         AddObjectProperty("ProductTypeName", gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypename, false, false);
         AddObjectProperty("ProductTypeProductQuantity", gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypeproductquantity, false, false);
         return  ;
      }

      [  SoapElement( ElementName = "ProductTypeCode" )]
      [  XmlElement( ElementName = "ProductTypeCode"   )]
      public short gxTpr_Producttypecode
      {
         get {
            return gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypecode ;
         }

         set {
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_N = 0;
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypecode = value;
            SetDirty("Producttypecode");
         }

      }

      [  SoapElement( ElementName = "ProductTypeName" )]
      [  XmlElement( ElementName = "ProductTypeName"   )]
      public string gxTpr_Producttypename
      {
         get {
            return gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypename ;
         }

         set {
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_N = 0;
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypename = value;
            SetDirty("Producttypename");
         }

      }

      [  SoapElement( ElementName = "ProductTypeProductQuantity" )]
      [  XmlElement( ElementName = "ProductTypeProductQuantity"   )]
      public int gxTpr_Producttypeproductquantity
      {
         get {
            return gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypeproductquantity ;
         }

         set {
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_N = 0;
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypeproductquantity = value;
            SetDirty("Producttypeproductquantity");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypename = "";
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_N = 1;
         return  ;
      }

      public short isNull( )
      {
         return gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_N ;
      }

      protected short gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypecode ;
      protected short gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_N ;
      protected int gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypeproductquantity ;
      protected string gxTv_SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_Producttypename ;
   }

   [DataContract(Name = @"WorkWithDevicesProductType_ProductType_Section_GeneralSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt_RESTInterface( SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ProductTypeCode" , Order = 0 )]
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
      public string gxTpr_Producttypeproductquantity
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Producttypeproductquantity), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Producttypeproductquantity = (int)(NumberUtil.Val( value, "."));
         }

      }

      public SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt sdt
      {
         get {
            return (SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesProductType_ProductType_Section_GeneralSdt() ;
         }
      }

   }

}
