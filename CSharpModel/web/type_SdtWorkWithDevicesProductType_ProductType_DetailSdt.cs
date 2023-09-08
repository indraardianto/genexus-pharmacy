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
   [XmlRoot(ElementName = "WorkWithDevicesProductType_ProductType_DetailSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesProductType_ProductType_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesProductType_ProductType_DetailSdt : GxUserType
   {
      public SdtWorkWithDevicesProductType_ProductType_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_Gxdynprop = "";
      }

      public SdtWorkWithDevicesProductType_ProductType_DetailSdt( IGxContext context )
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
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_Gxdynprop, false, false);
         return  ;
      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public string gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_N = 0;
            gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_Gxdynprop = "";
         gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_N = 1;
         return  ;
      }

      public short isNull( )
      {
         return gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_N ;
      }

      protected short gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_N ;
      protected string gxTv_SdtWorkWithDevicesProductType_ProductType_DetailSdt_Gxdynprop ;
   }

   [DataContract(Name = @"WorkWithDevicesProductType_ProductType_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesProductType_ProductType_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesProductType_ProductType_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesProductType_ProductType_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesProductType_ProductType_DetailSdt_RESTInterface( SdtWorkWithDevicesProductType_ProductType_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Gxdynprop" , Order = 0 )]
      public string gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtWorkWithDevicesProductType_ProductType_DetailSdt sdt
      {
         get {
            return (SdtWorkWithDevicesProductType_ProductType_DetailSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesProductType_ProductType_DetailSdt() ;
         }
      }

   }

}
