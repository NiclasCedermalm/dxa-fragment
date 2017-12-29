package com.sdl.dxa.modules.fragment;

import com.sdl.webapp.common.api.mapping.views.AbstractInitializer;
import com.sdl.webapp.common.api.mapping.views.ModuleInfo;
import com.sdl.webapp.common.api.mapping.views.RegisteredViewModel;
import com.sdl.webapp.common.api.mapping.views.RegisteredViewModels;
import com.sdl.webapp.common.api.model.page.DefaultPageModel;
import org.springframework.stereotype.Component;

/**
 * Initializer for the DXA Fragment module
 */
@Component
@ModuleInfo(name = "DXA Fragment", areaName = "Fragment", description = "Simple module to generate standalone fragments")
@RegisteredViewModels({
        @RegisteredViewModel(viewName = "FragmentPage", modelClass = DefaultPageModel.class),
        @RegisteredViewModel(viewName = "CleanFragmentPage", modelClass = DefaultPageModel.class)
})
public class FragmentModuleInitializer extends AbstractInitializer {

    @Override
    protected String getAreaName() {
        return "Fragment";
    }
}
