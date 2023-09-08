package com.artech.pharmacy.pharmacymenu;
import android.content.Context;
import androidx.multidex.MultiDex;

import com.artech.android.ContextImpl;
import com.artech.application.MyApplication;
import com.artech.base.metadata.GenexusApplication;
import com.artech.base.services.AndroidContext;
import com.artech.base.services.IGxProcedure;
import com.artech.base.services.Services;
import com.artech.providers.EntityDataProvider;
import com.artech.controls.ads.Ads;

import com.genexus.Application;
import com.genexus.ClientContext;

public class MainApplication extends MyApplication
{
	@Override
	public final void onCreate()
	{
		GenexusApplication application = new GenexusApplication();
		application.setName("pharmacy");
		application.setAPIUri("https://trialapps3.genexus.com/Idcbe717e1dc1808e333ce2637efbb0588/");
		application.setAppEntry("PharmacyMenu");
		application.setMajorVersion(1);
		application.setMinorVersion(0);

		// Extensibility Point for Logging
 

		// Security
		application.setIsSecure(false);
		application.setEnableAnonymousUser(false);
		application.setClientId("");
		application.setLoginObject("");
		application.setNotAuthorizedObject("");
		application.setChangePasswordObject("");
		//application.setCompleteUserDataObject("");

		application.setAllowWebViewExecuteJavascripts(true);
		application.setAllowWebViewExecuteLocalFiles(true);

		application.setShareSessionToWebView(false);

		// Dynamic Url		
		application.setUseDynamicUrl(false);
		application.setDynamicUrlAppId("Pharmacy");
		application.setDynamicUrlPanel("");

		// Notifications
		application.setUseNotification(false);
		application.setNotificationSenderId("");
		application.setNotificationRegistrationHandler("(none)");

		MyApplication.setApp(application);

		registerModule(new com.genexus.coreexternalobjects.CoreExternalObjectsModule());

		registerModule(new com.genexus.coreusercontrols.CoreUserControlsModule());

		registerModule(new com.genexus.controls.smartgrid.SmartGridModule());


	

		super.onCreate();

		
		AndroidContext.ApplicationContext = new ContextImpl(getApplicationContext());

    }

	@Override
	public Class<? extends com.artech.services.EntityService> getEntityServiceClass()
	{
		return AppEntityService.class;
	}

	@Override
	public EntityDataProvider getProvider()
	{
		return new AppEntityDataProvider();
	}

	@Override
	protected void attachBaseContext(Context base)
	{
		super.attachBaseContext(base);
		MultiDex.install(this);
	}

}
