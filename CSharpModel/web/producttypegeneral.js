gx.evt.autoSkip=!1;gx.define("producttypegeneral",!0,function(n){this.ServerClass="producttypegeneral";this.PackageName="GeneXus.Programs";this.ServerFullClass="producttypegeneral.aspx";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Producttypecode=function(){return this.validCliEvt("Valid_Producttypecode",0,function(){try{var n=gx.util.balloon.getNew("PRODUCTTYPECODE");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e110e1_client=function(){return this.clearMessages(),this.call("producttype.aspx",["UPD",this.A5ProductTypeCode],null,["Mode","ProductTypeCode"]),this.refreshOutputs([]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e120e1_client=function(){return this.clearMessages(),this.call("producttype.aspx",["DLT",this.A5ProductTypeCode],null,["Mode","ProductTypeCode"]),this.refreshOutputs([]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e150e2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160e2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28];this.GXLastCtrlId=28;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0,evt:"e110e1_client"};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0,evt:"e120e1_client"};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Producttypecode,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRODUCTTYPECODE",gxz:"Z5ProductTypeCode",gxold:"O5ProductTypeCode",gxvar:"A5ProductTypeCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5ProductTypeCode=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5ProductTypeCode=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PRODUCTTYPECODE",gx.O.A5ProductTypeCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A5ProductTypeCode=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PRODUCTTYPECODE",",")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"char",len:50,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRODUCTTYPENAME",gxz:"Z6ProductTypeName",gxold:"O6ProductTypeName",gxvar:"A6ProductTypeName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A6ProductTypeName=n)},v2z:function(n){n!==undefined&&(gx.O.Z6ProductTypeName=n)},v2c:function(){gx.fn.setControlValue("PRODUCTTYPENAME",gx.O.A6ProductTypeName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A6ProductTypeName=this.val())},val:function(){return gx.fn.getControlValue("PRODUCTTYPENAME")},nac:gx.falseFn};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PRODUCTTYPEPRODUCTQUANTITY",gxz:"Z8ProductTypeProductQuantity",gxold:"O8ProductTypeProductQuantity",gxvar:"A8ProductTypeProductQuantity",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A8ProductTypeProductQuantity=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z8ProductTypeProductQuantity=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PRODUCTTYPEPRODUCTQUANTITY",gx.O.A8ProductTypeProductQuantity,0)},c2v:function(){this.val()!==undefined&&(gx.O.A8ProductTypeProductQuantity=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PRODUCTTYPEPRODUCTQUANTITY",",")},nac:gx.falseFn};this.A5ProductTypeCode=0;this.Z5ProductTypeCode=0;this.O5ProductTypeCode=0;this.A6ProductTypeName="";this.Z6ProductTypeName="";this.O6ProductTypeName="";this.A8ProductTypeProductQuantity=0;this.Z8ProductTypeProductQuantity=0;this.O8ProductTypeProductQuantity=0;this.A5ProductTypeCode=0;this.A6ProductTypeName="";this.A8ProductTypeProductQuantity=0;this.Events={e150e2_client:["ENTER",!0],e160e2_client:["CANCEL",!0],e110e1_client:["'DOUPDATE'",!1],e120e1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[{av:"A5ProductTypeCode",fld:"PRODUCTTYPECODE",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6ProductTypeCode",fld:"vPRODUCTTYPECODE",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A5ProductTypeCode",fld:"PRODUCTTYPECODE",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A5ProductTypeCode",fld:"PRODUCTTYPECODE",pic:"ZZZ9"}],[]];this.EvtParms.ENTER=[[],[]];this.EvtParms.VALID_PRODUCTTYPECODE=[[],[]];this.Initialize()})