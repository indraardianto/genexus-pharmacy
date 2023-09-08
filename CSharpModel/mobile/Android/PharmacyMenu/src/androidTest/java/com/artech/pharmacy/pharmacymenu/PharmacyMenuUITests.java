package com.artech.pharmacy.pharmacymenu;

import androidx.test.ext.junit.runners.AndroidJUnit4;
import androidx.test.filters.LargeTest;

import com.artech.activities.StartupActivity;
import com.artech.base.services.IGxProcedure;
import com.artech.layers.GxObjectFactory;
import com.artech.utils.UITestingUtils;
import com.genexus.uitesting.rules.GenexusActivityTestRule;

import org.junit.FixMethodOrder;
import org.junit.Rule;
import org.junit.Test;
import org.junit.rules.TestWatcher;
import org.junit.runner.Description;
import org.junit.runner.RunWith;
import org.junit.runners.MethodSorters;

@FixMethodOrder(MethodSorters.NAME_ASCENDING)
@RunWith(AndroidJUnit4.class)
@LargeTest
public class PharmacyMenuUITests {
    @Rule
    public GenexusActivityTestRule<StartupActivity> mActivityRule = new GenexusActivityTestRule<>(StartupActivity.class);

    @Rule
    public TestWatcher watcher = new TestWatcher() {
        @Override
        protected void starting(Description description) {
            UITestingUtils.Companion.setVisualTestingServer("");
            UITestingUtils.Companion.setCurrentTest(description.getClassName(), description.getMethodName());
        }
    };

}
