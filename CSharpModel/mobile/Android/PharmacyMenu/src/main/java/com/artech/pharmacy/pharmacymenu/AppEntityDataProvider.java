package com.artech.pharmacy.pharmacymenu;

import com.artech.providers.EntityDataProvider;

public class AppEntityDataProvider extends EntityDataProvider
{
	public AppEntityDataProvider()
	{
		EntityDataProvider.AUTHORITY = "com.artech.pharmacy.pharmacymenu.appentityprovider";
		EntityDataProvider.URI_MATCHER = buildUriMatcher();
	}
}
