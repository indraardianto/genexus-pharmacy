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
   [XmlRoot(ElementName = "Item" )]
   [XmlType(TypeName =  "Item" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item : GxUserType
   {
      public SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto = "";
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto_gxi = "";
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productname = "";
      }

      public SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("ProductCode", gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productcode, false, false);
         AddObjectProperty("ProductPhoto", gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto, false, false);
         AddObjectProperty("ProductPhoto_GXI", gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto_gxi, false, false);
         AddObjectProperty("ProductName", gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productname, false, false);
         return  ;
      }

      [  SoapElement( ElementName = "ProductCode" )]
      [  XmlElement( ElementName = "ProductCode"   )]
      public short gxTpr_Productcode
      {
         get {
            return gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productcode ;
         }

         set {
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_N = 0;
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productcode = value;
            SetDirty("Productcode");
         }

      }

      [  SoapElement( ElementName = "ProductPhoto" )]
      [  XmlElement( ElementName = "ProductPhoto"   )]
      [GxUpload()]
      public string gxTpr_Productphoto
      {
         get {
            return gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto ;
         }

         set {
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_N = 0;
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto = value;
            SetDirty("Productphoto");
         }

      }

      [  SoapElement( ElementName = "ProductPhoto_GXI" )]
      [  XmlElement( ElementName = "ProductPhoto_GXI"   )]
      public string gxTpr_Productphoto_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_N = 0;
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto_gxi = value;
            SetDirty("Productphoto_gxi");
         }

      }

      [  SoapElement( ElementName = "ProductName" )]
      [  XmlElement( ElementName = "ProductName"   )]
      public string gxTpr_Productname
      {
         get {
            return gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productname ;
         }

         set {
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_N = 0;
            gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productname = value;
            SetDirty("Productname");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto = "";
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto_gxi = "";
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productname = "";
         gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_N = 1;
         return  ;
      }

      public short isNull( )
      {
         return gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_N ;
      }

      protected short gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productcode ;
      protected short gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_N ;
      protected string gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productname ;
      protected string gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto_gxi ;
      protected string gxTv_SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_Productphoto ;
   }

   [DataContract(Name = @"WorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item_RESTInterface( SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ProductCode" , Order = 0 )]
      public Nullable<short> gxTpr_Productcode
      {
         get {
            return sdt.gxTpr_Productcode ;
         }

         set {
            sdt.gxTpr_Productcode = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "ProductPhoto" , Order = 1 )]
      [GxUpload()]
      public string gxTpr_Productphoto
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Productphoto)) ? PathUtil.RelativeURL( sdt.gxTpr_Productphoto) : StringUtil.RTrim( sdt.gxTpr_Productphoto_gxi)) ;
         }

         set {
            sdt.gxTpr_Productphoto = value;
         }

      }

      [DataMember( Name = "ProductName" , Order = 2 )]
      public string gxTpr_Productname
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Productname) ;
         }

         set {
            sdt.gxTpr_Productname = value;
         }

      }

      public SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesProductType_ProductType_Section_Product_Grid1Sdt_Item() ;
         }
      }

   }

}
