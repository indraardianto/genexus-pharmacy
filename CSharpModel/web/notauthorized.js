gx.evt.autoSkip=!1;gx.define("notauthorized",!1,function(){this.ServerClass="notauthorized";this.PackageName="GeneXus.Programs";this.ServerFullClass="notauthorized.aspx";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.GxObject=gx.fn.getControlValue("vGXOBJECT")};this.e130a2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140a2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[4,7,13,16];this.GXLastCtrlId=16;n[4]={id:4,fld:"TABLE1",grid:0};n[7]={id:7,fld:"TITLETEXT",format:0,grid:0,ctrltype:"textblock"};n[13]={id:13,fld:"TABLE2",grid:0};n[16]={id:16,fld:"TABLE3",grid:0};this.GxObject="";this.Events={e130a2_client:["ENTER",!0],e140a2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV8Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"RECENTLINKS"}]];this.EvtParms.ENTER=[[],[]];this.setVCMap("GxObject","vGXOBJECT",0,"svchar",256,0);this.Initialize();this.setComponent({id:"HEADERBC",GXClass:null,Prefix:"W0002",lvl:1});this.setComponent({id:"RECENTLINKS",GXClass:null,Prefix:"W0003",lvl:1})});gx.wi(function(){gx.createParentObj(this.notauthorized)})