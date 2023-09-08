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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class producttype_bc : GXHttpHandler, IGxSilentTrn
   {
      public producttype_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public producttype_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtProductType> GetAll( int Start ,
                                                    int Count )
      {
         GXPagingFrom2 = Start;
         GXPagingTo2 = Count;
         /* Using cursor BC00027 */
         pr_default.execute(3, new Object[] {GXPagingFrom2, GXPagingTo2});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound2 = 1;
            A5ProductTypeCode = BC00027_A5ProductTypeCode[0];
            A6ProductTypeName = BC00027_A6ProductTypeName[0];
            A8ProductTypeProductQuantity = BC00027_A8ProductTypeProductQuantity[0];
            n8ProductTypeProductQuantity = BC00027_n8ProductTypeProductQuantity[0];
         }
         bcProductType = new SdtProductType(context);
         gx_restcollection.Clear();
         while ( RcdFound2 != 0 )
         {
            OnLoadActions022( ) ;
            AddRow022( ) ;
            gx_sdt_item = (SdtProductType)(bcProductType.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(3);
            RcdFound2 = 0;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(3) != 101) )
            {
               RcdFound2 = 1;
               A5ProductTypeCode = BC00027_A5ProductTypeCode[0];
               A6ProductTypeName = BC00027_A6ProductTypeName[0];
               A8ProductTypeProductQuantity = BC00027_A8ProductTypeProductQuantity[0];
               n8ProductTypeProductQuantity = BC00027_n8ProductTypeProductQuantity[0];
            }
            Gx_mode = sMode2;
         }
         pr_default.close(3);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM022( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow022( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey022( ) ;
         standaloneModal( ) ;
         AddRow022( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( endTrnMsgTxt)) )
            {
               GX_msglist.addItem(endTrnMsgTxt, endTrnMsgCod, 0, "", true);
            }
            /* Execute user event: After Trn */
            E11022 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               Z5ProductTypeCode = A5ProductTypeCode;
               SetMode( "UPD") ;
            }
         }
         endTrnMsgTxt = "";
      }

      public override string ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_020( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls022( ) ;
            }
            else
            {
               CheckExtendedTable022( ) ;
               if ( AnyError == 0 )
               {
                  ZM022( 2) ;
               }
               CloseExtendedTableCursors022( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12022( )
      {
         /* Start Routine */
         returnInSub = false;
      }

      protected void E11022( )
      {
         /* After Trn Routine */
         returnInSub = false;
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z6ProductTypeName = A6ProductTypeName;
            Z8ProductTypeProductQuantity = A8ProductTypeProductQuantity;
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z8ProductTypeProductQuantity = A8ProductTypeProductQuantity;
         }
         if ( GX_JID == -1 )
         {
            Z5ProductTypeCode = A5ProductTypeCode;
            Z6ProductTypeName = A6ProductTypeName;
            Z8ProductTypeProductQuantity = A8ProductTypeProductQuantity;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load022( )
      {
         /* Using cursor BC00029 */
         pr_default.execute(4, new Object[] {A5ProductTypeCode});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound2 = 1;
            A6ProductTypeName = BC00029_A6ProductTypeName[0];
            A8ProductTypeProductQuantity = BC00029_A8ProductTypeProductQuantity[0];
            n8ProductTypeProductQuantity = BC00029_n8ProductTypeProductQuantity[0];
            ZM022( -1) ;
         }
         pr_default.close(4);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         nIsDirty_2 = 0;
         standaloneModal( ) ;
         /* Using cursor BC00025 */
         pr_default.execute(2, new Object[] {A5ProductTypeCode});
         if ( (pr_default.getStatus(2) != 101) )
         {
            A8ProductTypeProductQuantity = BC00025_A8ProductTypeProductQuantity[0];
            n8ProductTypeProductQuantity = BC00025_n8ProductTypeProductQuantity[0];
         }
         else
         {
            nIsDirty_2 = 1;
            A8ProductTypeProductQuantity = 0;
            n8ProductTypeProductQuantity = false;
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey022( )
      {
         /* Using cursor BC000210 */
         pr_default.execute(5, new Object[] {A5ProductTypeCode});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00023 */
         pr_default.execute(1, new Object[] {A5ProductTypeCode});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 1) ;
            RcdFound2 = 1;
            A5ProductTypeCode = BC00023_A5ProductTypeCode[0];
            A6ProductTypeName = BC00023_A6ProductTypeName[0];
            Z5ProductTypeCode = A5ProductTypeCode;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load022( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey022( ) ;
            }
            Gx_mode = sMode2;
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode2;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_020( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor BC00022 */
            pr_default.execute(0, new Object[] {A5ProductTypeCode});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProductType"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z6ProductTypeName, BC00022_A6ProductTypeName[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ProductType"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000211 */
                     pr_default.execute(6, new Object[] {A6ProductTypeName});
                     A5ProductTypeCode = BC000211_A5ProductTypeCode[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("ProductType");
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           endTrnMsgTxt = context.GetMessage( "GXM_sucadded", "");
                           endTrnMsgCod = "SuccessfullyAdded";
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000212 */
                     pr_default.execute(7, new Object[] {A6ProductTypeName, A5ProductTypeCode});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("ProductType");
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProductType"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate022( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           endTrnMsgTxt = context.GetMessage( "GXM_sucupdated", "");
                           endTrnMsgCod = "SuccessfullyUpdated";
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000213 */
                  pr_default.execute(8, new Object[] {A5ProductTypeCode});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("ProductType");
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        endTrnMsgTxt = context.GetMessage( "GXM_sucdeleted", "");
                        endTrnMsgCod = "SuccessfullyDeleted";
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel022( ) ;
         Gx_mode = sMode2;
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000215 */
            pr_default.execute(9, new Object[] {A5ProductTypeCode});
            if ( (pr_default.getStatus(9) != 101) )
            {
               A8ProductTypeProductQuantity = BC000215_A8ProductTypeProductQuantity[0];
               n8ProductTypeProductQuantity = BC000215_n8ProductTypeProductQuantity[0];
            }
            else
            {
               A8ProductTypeProductQuantity = 0;
               n8ProductTypeProductQuantity = false;
            }
            pr_default.close(9);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000216 */
            pr_default.execute(10, new Object[] {A5ProductTypeCode});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Product"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel022( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart022( )
      {
         /* Scan By routine */
         /* Using cursor BC000218 */
         pr_default.execute(11, new Object[] {A5ProductTypeCode});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound2 = 1;
            A5ProductTypeCode = BC000218_A5ProductTypeCode[0];
            A6ProductTypeName = BC000218_A6ProductTypeName[0];
            A8ProductTypeProductQuantity = BC000218_A8ProductTypeProductQuantity[0];
            n8ProductTypeProductQuantity = BC000218_n8ProductTypeProductQuantity[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext022( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound2 = 0;
         ScanKeyLoad022( ) ;
      }

      protected void ScanKeyLoad022( )
      {
         sMode2 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound2 = 1;
            A5ProductTypeCode = BC000218_A5ProductTypeCode[0];
            A6ProductTypeName = BC000218_A6ProductTypeName[0];
            A8ProductTypeProductQuantity = BC000218_A8ProductTypeProductQuantity[0];
            n8ProductTypeProductQuantity = BC000218_n8ProductTypeProductQuantity[0];
         }
         Gx_mode = sMode2;
      }

      protected void ScanKeyEnd022( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
      }

      protected void send_integrity_lvl_hashes022( )
      {
      }

      protected void AddRow022( )
      {
         VarsToRow2( bcProductType) ;
      }

      protected void ReadRow022( )
      {
         RowToVars2( bcProductType, 1) ;
      }

      protected void InitializeNonKey022( )
      {
         A6ProductTypeName = "";
         A8ProductTypeProductQuantity = 0;
         n8ProductTypeProductQuantity = false;
         Z6ProductTypeName = "";
      }

      protected void InitAll022( )
      {
         A5ProductTypeCode = 0;
         InitializeNonKey022( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public void VarsToRow2( SdtProductType obj2 )
      {
         obj2.gxTpr_Mode = Gx_mode;
         obj2.gxTpr_Producttypename = A6ProductTypeName;
         obj2.gxTpr_Producttypeproductquantity = A8ProductTypeProductQuantity;
         obj2.gxTpr_Producttypecode = A5ProductTypeCode;
         obj2.gxTpr_Producttypecode_Z = Z5ProductTypeCode;
         obj2.gxTpr_Producttypename_Z = Z6ProductTypeName;
         obj2.gxTpr_Producttypeproductquantity_Z = Z8ProductTypeProductQuantity;
         obj2.gxTpr_Producttypeproductquantity_N = (short)(Convert.ToInt16(n8ProductTypeProductQuantity));
         obj2.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow2( SdtProductType obj2 )
      {
         obj2.gxTpr_Producttypecode = A5ProductTypeCode;
         return  ;
      }

      public void RowToVars2( SdtProductType obj2 ,
                              int forceLoad )
      {
         Gx_mode = obj2.gxTpr_Mode;
         A6ProductTypeName = obj2.gxTpr_Producttypename;
         A8ProductTypeProductQuantity = obj2.gxTpr_Producttypeproductquantity;
         n8ProductTypeProductQuantity = false;
         A5ProductTypeCode = obj2.gxTpr_Producttypecode;
         Z5ProductTypeCode = obj2.gxTpr_Producttypecode_Z;
         Z6ProductTypeName = obj2.gxTpr_Producttypename_Z;
         Z8ProductTypeProductQuantity = obj2.gxTpr_Producttypeproductquantity_Z;
         n8ProductTypeProductQuantity = (bool)(Convert.ToBoolean(obj2.gxTpr_Producttypeproductquantity_N));
         Gx_mode = obj2.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A5ProductTypeCode = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey022( ) ;
         ScanKeyStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z5ProductTypeCode = A5ProductTypeCode;
         }
         ZM022( -1) ;
         OnLoadActions022( ) ;
         AddRow022( ) ;
         ScanKeyEnd022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars2( bcProductType, 0) ;
         ScanKeyStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z5ProductTypeCode = A5ProductTypeCode;
         }
         ZM022( -1) ;
         OnLoadActions022( ) ;
         AddRow022( ) ;
         ScanKeyEnd022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey022( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            Insert022( ) ;
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( A5ProductTypeCode != Z5ProductTypeCode )
               {
                  A5ProductTypeCode = Z5ProductTypeCode;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update022( ) ;
               }
            }
            else
            {
               if ( IsDlt( ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( A5ProductTypeCode != Z5ProductTypeCode )
                  {
                     if ( IsUpd( ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert022( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert022( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcProductType, 1) ;
         SaveImpl( ) ;
         VarsToRow2( bcProductType) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public bool Insert( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcProductType, 1) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert022( ) ;
         AfterTrn( ) ;
         VarsToRow2( bcProductType) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      protected void UpdateImpl( )
      {
         if ( IsUpd( ) )
         {
            SaveImpl( ) ;
         }
         else
         {
            SdtProductType auxBC = new SdtProductType(context);
            IGxSilentTrn auxTrn = auxBC.getTransaction();
            auxBC.Load(A5ProductTypeCode);
            if ( auxTrn.Errors() == 0 )
            {
               auxBC.UpdateDirties(bcProductType);
               auxBC.Save();
            }
            LclMsgLst = (msglist)(auxTrn.GetMessages());
            AnyError = (short)(auxTrn.Errors());
            context.GX_msglist = LclMsgLst;
            if ( auxTrn.Errors() == 0 )
            {
               Gx_mode = auxTrn.GetMode();
               AfterTrn( ) ;
            }
         }
      }

      public bool Update( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcProductType, 1) ;
         UpdateImpl( ) ;
         VarsToRow2( bcProductType) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public bool InsertOrUpdate( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcProductType, 1) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert022( ) ;
         if ( AnyError == 1 )
         {
            if ( StringUtil.StrCmp(context.GX_msglist.getItemValue(1), "DuplicatePrimaryKey") == 0 )
            {
               AnyError = 0;
               context.GX_msglist.removeAllItems();
               UpdateImpl( ) ;
            }
         }
         else
         {
            AfterTrn( ) ;
         }
         VarsToRow2( bcProductType) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars2( bcProductType, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey022( ) ;
         if ( RcdFound2 == 1 )
         {
            if ( IsIns( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A5ProductTypeCode != Z5ProductTypeCode )
            {
               A5ProductTypeCode = Z5ProductTypeCode;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( IsDlt( ) )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( A5ProductTypeCode != Z5ProductTypeCode )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( IsUpd( ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         pr_default.close(9);
         context.RollbackDataStores("producttype_bc",pr_default);
         VarsToRow2( bcProductType) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public string GetMode( )
      {
         Gx_mode = bcProductType.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( string lMode )
      {
         Gx_mode = lMode;
         bcProductType.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcProductType )
         {
            bcProductType = (SdtProductType)(sdt);
            if ( StringUtil.StrCmp(bcProductType.gxTpr_Mode, "") == 0 )
            {
               bcProductType.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow2( bcProductType) ;
            }
            else
            {
               RowToVars2( bcProductType, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcProductType.gxTpr_Mode, "") == 0 )
            {
               bcProductType.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars2( bcProductType, 1) ;
         return  ;
      }

      public void ForceCommitOnExit( )
      {
         mustCommit = true;
         return  ;
      }

      public SdtProductType ProductType_BC
      {
         get {
            return bcProductType ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections();
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(9);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         BC00027_A5ProductTypeCode = new short[1] ;
         BC00027_A6ProductTypeName = new string[] {""} ;
         BC00027_A8ProductTypeProductQuantity = new int[1] ;
         BC00027_n8ProductTypeProductQuantity = new bool[] {false} ;
         A6ProductTypeName = "";
         gx_restcollection = new GXBCCollection<SdtProductType>( context, "ProductType", "Pharmacy");
         sMode2 = "";
         Gx_mode = "";
         endTrnMsgTxt = "";
         endTrnMsgCod = "";
         Z6ProductTypeName = "";
         BC00029_A5ProductTypeCode = new short[1] ;
         BC00029_A6ProductTypeName = new string[] {""} ;
         BC00029_A8ProductTypeProductQuantity = new int[1] ;
         BC00029_n8ProductTypeProductQuantity = new bool[] {false} ;
         BC00025_A8ProductTypeProductQuantity = new int[1] ;
         BC00025_n8ProductTypeProductQuantity = new bool[] {false} ;
         BC000210_A5ProductTypeCode = new short[1] ;
         BC00023_A5ProductTypeCode = new short[1] ;
         BC00023_A6ProductTypeName = new string[] {""} ;
         BC00022_A5ProductTypeCode = new short[1] ;
         BC00022_A6ProductTypeName = new string[] {""} ;
         BC000211_A5ProductTypeCode = new short[1] ;
         BC000215_A8ProductTypeProductQuantity = new int[1] ;
         BC000215_n8ProductTypeProductQuantity = new bool[] {false} ;
         BC000216_A1ProductCode = new short[1] ;
         BC000218_A5ProductTypeCode = new short[1] ;
         BC000218_A6ProductTypeName = new string[] {""} ;
         BC000218_A8ProductTypeProductQuantity = new int[1] ;
         BC000218_n8ProductTypeProductQuantity = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.producttype_bc__default(),
            new Object[][] {
                new Object[] {
               BC00022_A5ProductTypeCode, BC00022_A6ProductTypeName
               }
               , new Object[] {
               BC00023_A5ProductTypeCode, BC00023_A6ProductTypeName
               }
               , new Object[] {
               BC00025_A8ProductTypeProductQuantity, BC00025_n8ProductTypeProductQuantity
               }
               , new Object[] {
               BC00027_A5ProductTypeCode, BC00027_A6ProductTypeName, BC00027_A8ProductTypeProductQuantity, BC00027_n8ProductTypeProductQuantity
               }
               , new Object[] {
               BC00029_A5ProductTypeCode, BC00029_A6ProductTypeName, BC00029_A8ProductTypeProductQuantity, BC00029_n8ProductTypeProductQuantity
               }
               , new Object[] {
               BC000210_A5ProductTypeCode
               }
               , new Object[] {
               BC000211_A5ProductTypeCode
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000215_A8ProductTypeProductQuantity, BC000215_n8ProductTypeProductQuantity
               }
               , new Object[] {
               BC000216_A1ProductCode
               }
               , new Object[] {
               BC000218_A5ProductTypeCode, BC000218_A6ProductTypeName, BC000218_A8ProductTypeProductQuantity, BC000218_n8ProductTypeProductQuantity
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12022 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound2 ;
      private short A5ProductTypeCode ;
      private short Z5ProductTypeCode ;
      private short GX_JID ;
      private short nIsDirty_2 ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int A8ProductTypeProductQuantity ;
      private int Z8ProductTypeProductQuantity ;
      private string scmdbuf ;
      private string PreviousTooltip ;
      private string PreviousCaption ;
      private string A6ProductTypeName ;
      private string sMode2 ;
      private string Gx_mode ;
      private string endTrnMsgTxt ;
      private string endTrnMsgCod ;
      private string Z6ProductTypeName ;
      private bool n8ProductTypeProductQuantity ;
      private bool returnInSub ;
      private bool mustCommit ;
      private GXBCCollection<SdtProductType> gx_restcollection ;
      private SdtProductType bcProductType ;
      private SdtProductType gx_sdt_item ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00027_A5ProductTypeCode ;
      private string[] BC00027_A6ProductTypeName ;
      private int[] BC00027_A8ProductTypeProductQuantity ;
      private bool[] BC00027_n8ProductTypeProductQuantity ;
      private short[] BC00029_A5ProductTypeCode ;
      private string[] BC00029_A6ProductTypeName ;
      private int[] BC00029_A8ProductTypeProductQuantity ;
      private bool[] BC00029_n8ProductTypeProductQuantity ;
      private int[] BC00025_A8ProductTypeProductQuantity ;
      private bool[] BC00025_n8ProductTypeProductQuantity ;
      private short[] BC000210_A5ProductTypeCode ;
      private short[] BC00023_A5ProductTypeCode ;
      private string[] BC00023_A6ProductTypeName ;
      private short[] BC00022_A5ProductTypeCode ;
      private string[] BC00022_A6ProductTypeName ;
      private short[] BC000211_A5ProductTypeCode ;
      private int[] BC000215_A8ProductTypeProductQuantity ;
      private bool[] BC000215_n8ProductTypeProductQuantity ;
      private short[] BC000216_A1ProductCode ;
      private short[] BC000218_A5ProductTypeCode ;
      private string[] BC000218_A6ProductTypeName ;
      private int[] BC000218_A8ProductTypeProductQuantity ;
      private bool[] BC000218_n8ProductTypeProductQuantity ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class producttype_bc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00027;
          prmBC00027 = new Object[] {
          new ParDef("@GXPagingFrom2",GXType.Int32,9,0) ,
          new ParDef("@GXPagingTo2",GXType.Int32,9,0)
          };
          Object[] prmBC00029;
          prmBC00029 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          Object[] prmBC00025;
          prmBC00025 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          Object[] prmBC000210;
          prmBC000210 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          Object[] prmBC00023;
          prmBC00023 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          Object[] prmBC00022;
          prmBC00022 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          Object[] prmBC000211;
          prmBC000211 = new Object[] {
          new ParDef("@ProductTypeName",GXType.NChar,50,0)
          };
          Object[] prmBC000212;
          prmBC000212 = new Object[] {
          new ParDef("@ProductTypeName",GXType.NChar,50,0) ,
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          Object[] prmBC000213;
          prmBC000213 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          Object[] prmBC000215;
          prmBC000215 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          Object[] prmBC000216;
          prmBC000216 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          Object[] prmBC000218;
          prmBC000218 = new Object[] {
          new ParDef("@ProductTypeCode",GXType.Int16,4,0)
          };
          def= new CursorDef[] {
              new CursorDef("BC00022", "SELECT [ProductTypeCode], [ProductTypeName] FROM [ProductType] WITH (UPDLOCK) WHERE [ProductTypeCode] = @ProductTypeCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00022,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00023", "SELECT [ProductTypeCode], [ProductTypeName] FROM [ProductType] WHERE [ProductTypeCode] = @ProductTypeCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00023,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00025", "SELECT COALESCE( T1.[ProductTypeProductQuantity], 0) AS ProductTypeProductQuantity FROM (SELECT COUNT(*) AS ProductTypeProductQuantity, [ProductTypeCode] FROM [Product] GROUP BY [ProductTypeCode] ) T1 WHERE T1.[ProductTypeCode] = @ProductTypeCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00025,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00027", "SELECT TM1.[ProductTypeCode], TM1.[ProductTypeName], COALESCE( T2.[ProductTypeProductQuantity], 0) AS ProductTypeProductQuantity FROM ([ProductType] TM1 LEFT JOIN (SELECT COUNT(*) AS ProductTypeProductQuantity, [ProductTypeCode] FROM [Product] GROUP BY [ProductTypeCode] ) T2 ON T2.[ProductTypeCode] = TM1.[ProductTypeCode]) ORDER BY TM1.[ProductTypeCode]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00027,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00029", "SELECT TM1.[ProductTypeCode], TM1.[ProductTypeName], COALESCE( T2.[ProductTypeProductQuantity], 0) AS ProductTypeProductQuantity FROM ([ProductType] TM1 LEFT JOIN (SELECT COUNT(*) AS ProductTypeProductQuantity, [ProductTypeCode] FROM [Product] GROUP BY [ProductTypeCode] ) T2 ON T2.[ProductTypeCode] = TM1.[ProductTypeCode]) WHERE TM1.[ProductTypeCode] = @ProductTypeCode ORDER BY TM1.[ProductTypeCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00029,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC000210", "SELECT [ProductTypeCode] FROM [ProductType] WHERE [ProductTypeCode] = @ProductTypeCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000210,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC000211", "INSERT INTO [ProductType]([ProductTypeName]) VALUES(@ProductTypeName); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000211)
             ,new CursorDef("BC000212", "UPDATE [ProductType] SET [ProductTypeName]=@ProductTypeName  WHERE [ProductTypeCode] = @ProductTypeCode", GxErrorMask.GX_NOMASK,prmBC000212)
             ,new CursorDef("BC000213", "DELETE FROM [ProductType]  WHERE [ProductTypeCode] = @ProductTypeCode", GxErrorMask.GX_NOMASK,prmBC000213)
             ,new CursorDef("BC000215", "SELECT COALESCE( T1.[ProductTypeProductQuantity], 0) AS ProductTypeProductQuantity FROM (SELECT COUNT(*) AS ProductTypeProductQuantity, [ProductTypeCode] FROM [Product] GROUP BY [ProductTypeCode] ) T1 WHERE T1.[ProductTypeCode] = @ProductTypeCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000215,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC000216", "SELECT TOP 1 [ProductCode] FROM [Product] WHERE [ProductTypeCode] = @ProductTypeCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000216,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("BC000218", "SELECT TM1.[ProductTypeCode], TM1.[ProductTypeName], COALESCE( T2.[ProductTypeProductQuantity], 0) AS ProductTypeProductQuantity FROM ([ProductType] TM1 LEFT JOIN (SELECT COUNT(*) AS ProductTypeProductQuantity, [ProductTypeCode] FROM [Product] GROUP BY [ProductTypeCode] ) T2 ON T2.[ProductTypeCode] = TM1.[ProductTypeCode]) WHERE TM1.[ProductTypeCode] = @ProductTypeCode ORDER BY TM1.[ProductTypeCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000218,100, GxCacheFrequency.OFF ,true,false )
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
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getString(2, 50);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1);
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getString(2, 50);
                ((int[]) buf[2])[0] = rslt.getInt(3);
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getString(2, 50);
                ((int[]) buf[2])[0] = rslt.getInt(3);
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1);
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getString(2, 50);
                ((int[]) buf[2])[0] = rslt.getInt(3);
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.producttype_bc_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class producttype_bc_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA5ProductTypeCode}")]
    public SdtProductType_RESTInterface Load( string sA5ProductTypeCode )
    {
       try
       {
          short A5ProductTypeCode;
          A5ProductTypeCode = (short)(NumberUtil.Val( (string)(sA5ProductTypeCode), "."));
          SdtProductType worker = new SdtProductType(context);
          SdtProductType_RESTInterface worker_interface = new SdtProductType_RESTInterface (worker);
          if ( StringUtil.StrCmp(sA5ProductTypeCode, "_default") == 0 )
          {
             IGxSilentTrn workertrn = worker.getTransaction();
             workertrn.GetInsDefault();
          }
          else
          {
             worker.Load(A5ProductTypeCode);
          }
          ((GXHttpHandler)worker.trn).IsMain = true ;
          if ( worker.Success() )
          {
             SetMessages(worker.trn.GetMessages());
             worker.trn.cleanup( );
             return worker_interface ;
          }
          else
          {
             worker.trn.cleanup( );
             ErrorCheck(worker.trn);
             return null ;
          }
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

    [OperationContract]
    [WebInvoke(Method =  "DELETE" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA5ProductTypeCode}")]
    public SdtProductType_RESTInterface Delete( string sA5ProductTypeCode )
    {
       try
       {
          short A5ProductTypeCode;
          A5ProductTypeCode = (short)(NumberUtil.Val( (string)(sA5ProductTypeCode), "."));
          SdtProductType worker = new SdtProductType(context);
          SdtProductType_RESTInterface worker_interface = new SdtProductType_RESTInterface (worker);
          worker.Load(A5ProductTypeCode);
          worker.Delete();
          ((GXHttpHandler)worker.trn).IsMain = true ;
          if ( worker.Success() )
          {
             (( GXHttpHandler )worker.trn).context.CommitDataStores();
             SetMessages(worker.trn.GetMessages());
             worker.trn.cleanup( );
             return worker_interface ;
          }
          else
          {
             worker.trn.cleanup( );
             ErrorCheck(worker.trn);
             return null ;
          }
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

    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA5ProductTypeCode}")]
    public SdtProductType_RESTInterface Insert( string sA5ProductTypeCode ,
                                                SdtProductType_RESTInterface entity )
    {
       try
       {
          short A5ProductTypeCode;
          A5ProductTypeCode = (short)(NumberUtil.Val( (string)(sA5ProductTypeCode), "."));
          SdtProductType worker = new SdtProductType(context);
          bool gxcheck = RestParameter("check", "true");
          bool gxinsertorupdate = RestParameter("insertorupdate", "true");
          SdtProductType_RESTInterface worker_interface = new SdtProductType_RESTInterface (worker);
          worker_interface.CopyFrom(entity);
          worker.gxTpr_Producttypecode = A5ProductTypeCode;
          if ( gxcheck )
          {
             worker.Check();
          }
          else
          {
             if ( gxinsertorupdate )
             {
                worker.InsertOrUpdate();
             }
             else
             {
                worker.Save();
             }
          }
          ((GXHttpHandler)worker.trn).IsMain = true ;
          if ( worker.Success() )
          {
             if ( ! gxcheck )
             {
                (( GXHttpHandler )worker.trn).context.CommitDataStores();
                SetStatusCode(System.Net.HttpStatusCode.Created);
             }
             SetMessages(worker.trn.GetMessages());
             worker.trn.cleanup( );
             return worker_interface ;
          }
          else
          {
             worker.trn.cleanup( );
             ErrorCheck(worker.trn);
             return null ;
          }
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

    [OperationContract]
    [WebInvoke(Method =  "PUT" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA5ProductTypeCode}")]
    public SdtProductType_RESTInterface Update( string sA5ProductTypeCode ,
                                                SdtProductType_RESTInterface entity )
    {
       try
       {
          short A5ProductTypeCode;
          A5ProductTypeCode = (short)(NumberUtil.Val( (string)(sA5ProductTypeCode), "."));
          SdtProductType worker = new SdtProductType(context);
          SdtProductType_RESTInterface worker_interface = new SdtProductType_RESTInterface (worker);
          bool gxcheck = RestParameter("check", "true");
          worker.Load(A5ProductTypeCode);
          if (entity.Hash == worker_interface.Hash) {
             worker_interface.CopyFrom(entity);
             worker.gxTpr_Producttypecode = A5ProductTypeCode;
             if ( gxcheck )
             {
                worker.Check();
             }
             else
             {
                worker.Save();
             }
             ((GXHttpHandler)worker.trn).IsMain = true ;
             if ( worker.Success() )
             {
                if ( ! gxcheck )
                {
                   (( GXHttpHandler )worker.trn).context.CommitDataStores();
                }
                SetMessages(worker.trn.GetMessages());
                worker.trn.cleanup( );
                worker_interface.Hash = null;
                return worker_interface ;
             }
             else
             {
                worker.trn.cleanup( );
                ErrorCheck(worker.trn);
                return null ;
             }
          }
          else
          {
             SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"ProductType"}) );
          }
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
