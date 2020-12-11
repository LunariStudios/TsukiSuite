#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace Lunari.Tsuki.Editor {
    public static class GUIStyles {
        public static GUIStyle Get(string key, EditorSkin skin) {
            return EditorGUIUtility.GetBuiltinSkin(skin).FindStyle(key);
        }

        public const string box = "box";
        public static GUIStyle box_Game => Get(box, EditorSkin.Game);
        public static GUIStyle box_Inspector => Get(box, EditorSkin.Inspector);
        public static GUIStyle box_Scene => Get(box, EditorSkin.Scene);
        public const string button = "button";
        public static GUIStyle button_Game => Get(button, EditorSkin.Game);
        public static GUIStyle button_Inspector => Get(button, EditorSkin.Inspector);
        public static GUIStyle button_Scene => Get(button, EditorSkin.Scene);
        public const string toggle = "toggle";
        public static GUIStyle toggle_Game => Get(toggle, EditorSkin.Game);
        public static GUIStyle toggle_Inspector => Get(toggle, EditorSkin.Inspector);
        public static GUIStyle toggle_Scene => Get(toggle, EditorSkin.Scene);
        public const string label = "label";
        public static GUIStyle label_Game => Get(label, EditorSkin.Game);
        public static GUIStyle label_Inspector => Get(label, EditorSkin.Inspector);
        public static GUIStyle label_Scene => Get(label, EditorSkin.Scene);
        public const string window = "window";
        public static GUIStyle window_Game => Get(window, EditorSkin.Game);
        public static GUIStyle window_Inspector => Get(window, EditorSkin.Inspector);
        public static GUIStyle window_Scene => Get(window, EditorSkin.Scene);
        public const string textfield = "textfield";
        public static GUIStyle textfield_Game => Get(textfield, EditorSkin.Game);
        public static GUIStyle textfield_Inspector => Get(textfield, EditorSkin.Inspector);
        public static GUIStyle textfield_Scene => Get(textfield, EditorSkin.Scene);
        public const string textarea = "textarea";
        public static GUIStyle textarea_Game => Get(textarea, EditorSkin.Game);
        public static GUIStyle textarea_Inspector => Get(textarea, EditorSkin.Inspector);
        public static GUIStyle textarea_Scene => Get(textarea, EditorSkin.Scene);
        public const string horizontalslider = "horizontalslider";
        public static GUIStyle horizontalslider_Game => Get(horizontalslider, EditorSkin.Game);
        public static GUIStyle horizontalslider_Inspector => Get(horizontalslider, EditorSkin.Inspector);
        public static GUIStyle horizontalslider_Scene => Get(horizontalslider, EditorSkin.Scene);
        public const string horizontalsliderthumb = "horizontalsliderthumb";
        public static GUIStyle horizontalsliderthumb_Game => Get(horizontalsliderthumb, EditorSkin.Game);
        public static GUIStyle horizontalsliderthumb_Inspector => Get(horizontalsliderthumb, EditorSkin.Inspector);
        public static GUIStyle horizontalsliderthumb_Scene => Get(horizontalsliderthumb, EditorSkin.Scene);
        public const string verticalslider = "verticalslider";
        public static GUIStyle verticalslider_Game => Get(verticalslider, EditorSkin.Game);
        public static GUIStyle verticalslider_Inspector => Get(verticalslider, EditorSkin.Inspector);
        public static GUIStyle verticalslider_Scene => Get(verticalslider, EditorSkin.Scene);
        public const string verticalsliderthumb = "verticalsliderthumb";
        public static GUIStyle verticalsliderthumb_Game => Get(verticalsliderthumb, EditorSkin.Game);
        public static GUIStyle verticalsliderthumb_Inspector => Get(verticalsliderthumb, EditorSkin.Inspector);
        public static GUIStyle verticalsliderthumb_Scene => Get(verticalsliderthumb, EditorSkin.Scene);
        public const string horizontalscrollbar = "horizontalscrollbar";
        public static GUIStyle horizontalscrollbar_Game => Get(horizontalscrollbar, EditorSkin.Game);
        public static GUIStyle horizontalscrollbar_Inspector => Get(horizontalscrollbar, EditorSkin.Inspector);
        public static GUIStyle horizontalscrollbar_Scene => Get(horizontalscrollbar, EditorSkin.Scene);
        public const string horizontalscrollbarthumb = "horizontalscrollbarthumb";
        public static GUIStyle horizontalscrollbarthumb_Game => Get(horizontalscrollbarthumb, EditorSkin.Game);

        public static GUIStyle horizontalscrollbarthumb_Inspector =>
            Get(horizontalscrollbarthumb, EditorSkin.Inspector);

        public static GUIStyle horizontalscrollbarthumb_Scene => Get(horizontalscrollbarthumb, EditorSkin.Scene);
        public const string horizontalscrollbarleftbutton = "horizontalscrollbarleftbutton";

        public static GUIStyle horizontalscrollbarleftbutton_Game =>
            Get(horizontalscrollbarleftbutton, EditorSkin.Game);

        public static GUIStyle horizontalscrollbarleftbutton_Inspector =>
            Get(horizontalscrollbarleftbutton, EditorSkin.Inspector);

        public static GUIStyle horizontalscrollbarleftbutton_Scene =>
            Get(horizontalscrollbarleftbutton, EditorSkin.Scene);

        public const string horizontalscrollbarrightbutton = "horizontalscrollbarrightbutton";

        public static GUIStyle horizontalscrollbarrightbutton_Game =>
            Get(horizontalscrollbarrightbutton, EditorSkin.Game);

        public static GUIStyle horizontalscrollbarrightbutton_Inspector =>
            Get(horizontalscrollbarrightbutton, EditorSkin.Inspector);

        public static GUIStyle horizontalscrollbarrightbutton_Scene =>
            Get(horizontalscrollbarrightbutton, EditorSkin.Scene);

        public const string verticalscrollbar = "verticalscrollbar";
        public static GUIStyle verticalscrollbar_Game => Get(verticalscrollbar, EditorSkin.Game);
        public static GUIStyle verticalscrollbar_Inspector => Get(verticalscrollbar, EditorSkin.Inspector);
        public static GUIStyle verticalscrollbar_Scene => Get(verticalscrollbar, EditorSkin.Scene);
        public const string verticalscrollbarthumb = "verticalscrollbarthumb";
        public static GUIStyle verticalscrollbarthumb_Game => Get(verticalscrollbarthumb, EditorSkin.Game);
        public static GUIStyle verticalscrollbarthumb_Inspector => Get(verticalscrollbarthumb, EditorSkin.Inspector);
        public static GUIStyle verticalscrollbarthumb_Scene => Get(verticalscrollbarthumb, EditorSkin.Scene);
        public const string verticalscrollbarupbutton = "verticalscrollbarupbutton";
        public static GUIStyle verticalscrollbarupbutton_Game => Get(verticalscrollbarupbutton, EditorSkin.Game);

        public static GUIStyle verticalscrollbarupbutton_Inspector =>
            Get(verticalscrollbarupbutton, EditorSkin.Inspector);

        public static GUIStyle verticalscrollbarupbutton_Scene => Get(verticalscrollbarupbutton, EditorSkin.Scene);
        public const string verticalscrollbardownbutton = "verticalscrollbardownbutton";
        public static GUIStyle verticalscrollbardownbutton_Game => Get(verticalscrollbardownbutton, EditorSkin.Game);

        public static GUIStyle verticalscrollbardownbutton_Inspector =>
            Get(verticalscrollbardownbutton, EditorSkin.Inspector);

        public static GUIStyle verticalscrollbardownbutton_Scene => Get(verticalscrollbardownbutton, EditorSkin.Scene);
        public const string scrollview = "scrollview";
        public static GUIStyle scrollview_Game => Get(scrollview, EditorSkin.Game);
        public static GUIStyle scrollview_Inspector => Get(scrollview, EditorSkin.Inspector);
        public static GUIStyle scrollview_Scene => Get(scrollview, EditorSkin.Scene);
        public const string AboutWIndowLicenseLabel = "AboutWIndowLicenseLabel";
        public static GUIStyle AboutWIndowLicenseLabel_Game => Get(AboutWIndowLicenseLabel, EditorSkin.Game);
        public static GUIStyle AboutWIndowLicenseLabel_Inspector => Get(AboutWIndowLicenseLabel, EditorSkin.Inspector);
        public static GUIStyle AboutWIndowLicenseLabel_Scene => Get(AboutWIndowLicenseLabel, EditorSkin.Scene);
        public const string AC_BoldHeader = "AC BoldHeader";
        public static GUIStyle AC_BoldHeader_Game => Get(AC_BoldHeader, EditorSkin.Game);
        public static GUIStyle AC_BoldHeader_Inspector => Get(AC_BoldHeader, EditorSkin.Inspector);
        public static GUIStyle AC_BoldHeader_Scene => Get(AC_BoldHeader, EditorSkin.Scene);
        public const string AC_Button = "AC Button";
        public static GUIStyle AC_Button_Game => Get(AC_Button, EditorSkin.Game);
        public static GUIStyle AC_Button_Inspector => Get(AC_Button, EditorSkin.Inspector);
        public static GUIStyle AC_Button_Scene => Get(AC_Button, EditorSkin.Scene);
        public const string AC_ComponentButton = "AC ComponentButton";
        public static GUIStyle AC_ComponentButton_Game => Get(AC_ComponentButton, EditorSkin.Game);
        public static GUIStyle AC_ComponentButton_Inspector => Get(AC_ComponentButton, EditorSkin.Inspector);
        public static GUIStyle AC_ComponentButton_Scene => Get(AC_ComponentButton, EditorSkin.Scene);
        public const string AC_GroupButton = "AC GroupButton";
        public static GUIStyle AC_GroupButton_Game => Get(AC_GroupButton, EditorSkin.Game);
        public static GUIStyle AC_GroupButton_Inspector => Get(AC_GroupButton, EditorSkin.Inspector);
        public static GUIStyle AC_GroupButton_Scene => Get(AC_GroupButton, EditorSkin.Scene);
        public const string AC_LeftArrow = "AC LeftArrow";
        public static GUIStyle AC_LeftArrow_Game => Get(AC_LeftArrow, EditorSkin.Game);
        public static GUIStyle AC_LeftArrow_Inspector => Get(AC_LeftArrow, EditorSkin.Inspector);
        public static GUIStyle AC_LeftArrow_Scene => Get(AC_LeftArrow, EditorSkin.Scene);
        public const string AC_PreviewHeader = "AC PreviewHeader";
        public static GUIStyle AC_PreviewHeader_Game => Get(AC_PreviewHeader, EditorSkin.Game);
        public static GUIStyle AC_PreviewHeader_Inspector => Get(AC_PreviewHeader, EditorSkin.Inspector);
        public static GUIStyle AC_PreviewHeader_Scene => Get(AC_PreviewHeader, EditorSkin.Scene);
        public const string AC_PreviewText = "AC PreviewText";
        public static GUIStyle AC_PreviewText_Game => Get(AC_PreviewText, EditorSkin.Game);
        public static GUIStyle AC_PreviewText_Inspector => Get(AC_PreviewText, EditorSkin.Inspector);
        public static GUIStyle AC_PreviewText_Scene => Get(AC_PreviewText, EditorSkin.Scene);
        public const string AC_RightArrow = "AC RightArrow";
        public static GUIStyle AC_RightArrow_Game => Get(AC_RightArrow, EditorSkin.Game);
        public static GUIStyle AC_RightArrow_Inspector => Get(AC_RightArrow, EditorSkin.Inspector);
        public static GUIStyle AC_RightArrow_Scene => Get(AC_RightArrow, EditorSkin.Scene);
        public const string AM_ChannelStripHeaderStyle = "AM ChannelStripHeaderStyle";
        public static GUIStyle AM_ChannelStripHeaderStyle_Game => Get(AM_ChannelStripHeaderStyle, EditorSkin.Game);

        public static GUIStyle AM_ChannelStripHeaderStyle_Inspector =>
            Get(AM_ChannelStripHeaderStyle, EditorSkin.Inspector);

        public static GUIStyle AM_ChannelStripHeaderStyle_Scene => Get(AM_ChannelStripHeaderStyle, EditorSkin.Scene);
        public const string AM_EffectName = "AM EffectName";
        public static GUIStyle AM_EffectName_Game => Get(AM_EffectName, EditorSkin.Game);
        public static GUIStyle AM_EffectName_Inspector => Get(AM_EffectName, EditorSkin.Inspector);
        public static GUIStyle AM_EffectName_Scene => Get(AM_EffectName, EditorSkin.Scene);
        public const string AM_HeaderStyle = "AM HeaderStyle";
        public static GUIStyle AM_HeaderStyle_Game => Get(AM_HeaderStyle, EditorSkin.Game);
        public static GUIStyle AM_HeaderStyle_Inspector => Get(AM_HeaderStyle, EditorSkin.Inspector);
        public static GUIStyle AM_HeaderStyle_Scene => Get(AM_HeaderStyle, EditorSkin.Scene);
        public const string AM_MixerHeader = "AM MixerHeader";
        public static GUIStyle AM_MixerHeader_Game => Get(AM_MixerHeader, EditorSkin.Game);
        public static GUIStyle AM_MixerHeader_Inspector => Get(AM_MixerHeader, EditorSkin.Inspector);
        public static GUIStyle AM_MixerHeader_Scene => Get(AM_MixerHeader, EditorSkin.Scene);
        public const string AM_MixerHeader2 = "AM MixerHeader2";
        public static GUIStyle AM_MixerHeader2_Game => Get(AM_MixerHeader2, EditorSkin.Game);
        public static GUIStyle AM_MixerHeader2_Inspector => Get(AM_MixerHeader2, EditorSkin.Inspector);
        public static GUIStyle AM_MixerHeader2_Scene => Get(AM_MixerHeader2, EditorSkin.Scene);
        public const string AM_ToolbarLabel = "AM ToolbarLabel";
        public static GUIStyle AM_ToolbarLabel_Game => Get(AM_ToolbarLabel, EditorSkin.Game);
        public static GUIStyle AM_ToolbarLabel_Inspector => Get(AM_ToolbarLabel, EditorSkin.Inspector);
        public static GUIStyle AM_ToolbarLabel_Scene => Get(AM_ToolbarLabel, EditorSkin.Scene);
        public const string AM_ToolbarObjectField = "AM ToolbarObjectField";
        public static GUIStyle AM_ToolbarObjectField_Game => Get(AM_ToolbarObjectField, EditorSkin.Game);
        public static GUIStyle AM_ToolbarObjectField_Inspector => Get(AM_ToolbarObjectField, EditorSkin.Inspector);
        public static GUIStyle AM_ToolbarObjectField_Scene => Get(AM_ToolbarObjectField, EditorSkin.Scene);
        public const string AM_TotalVuLabel = "AM TotalVuLabel";
        public static GUIStyle AM_TotalVuLabel_Game => Get(AM_TotalVuLabel, EditorSkin.Game);
        public static GUIStyle AM_TotalVuLabel_Inspector => Get(AM_TotalVuLabel, EditorSkin.Inspector);
        public static GUIStyle AM_TotalVuLabel_Scene => Get(AM_TotalVuLabel, EditorSkin.Scene);
        public const string AM_VuValue = "AM VuValue";
        public static GUIStyle AM_VuValue_Game => Get(AM_VuValue, EditorSkin.Game);
        public static GUIStyle AM_VuValue_Inspector => Get(AM_VuValue, EditorSkin.Inspector);
        public static GUIStyle AM_VuValue_Scene => Get(AM_VuValue, EditorSkin.Scene);
        public const string AnimationEventBackground = "AnimationEventBackground";
        public static GUIStyle AnimationEventBackground_Game => Get(AnimationEventBackground, EditorSkin.Game);

        public static GUIStyle AnimationEventBackground_Inspector =>
            Get(AnimationEventBackground, EditorSkin.Inspector);

        public static GUIStyle AnimationEventBackground_Scene => Get(AnimationEventBackground, EditorSkin.Scene);
        public const string AnimationEventTooltip = "AnimationEventTooltip";
        public static GUIStyle AnimationEventTooltip_Game => Get(AnimationEventTooltip, EditorSkin.Game);
        public static GUIStyle AnimationEventTooltip_Inspector => Get(AnimationEventTooltip, EditorSkin.Inspector);
        public static GUIStyle AnimationEventTooltip_Scene => Get(AnimationEventTooltip, EditorSkin.Scene);
        public const string AnimationEventTooltipArrow = "AnimationEventTooltipArrow";
        public static GUIStyle AnimationEventTooltipArrow_Game => Get(AnimationEventTooltipArrow, EditorSkin.Game);

        public static GUIStyle AnimationEventTooltipArrow_Inspector =>
            Get(AnimationEventTooltipArrow, EditorSkin.Inspector);

        public static GUIStyle AnimationEventTooltipArrow_Scene => Get(AnimationEventTooltipArrow, EditorSkin.Scene);
        public const string AnimationKeyframeBackground = "AnimationKeyframeBackground";
        public static GUIStyle AnimationKeyframeBackground_Game => Get(AnimationKeyframeBackground, EditorSkin.Game);

        public static GUIStyle AnimationKeyframeBackground_Inspector =>
            Get(AnimationKeyframeBackground, EditorSkin.Inspector);

        public static GUIStyle AnimationKeyframeBackground_Scene => Get(AnimationKeyframeBackground, EditorSkin.Scene);
        public const string AnimationPlayHead = "AnimationPlayHead";
        public static GUIStyle AnimationPlayHead_Game => Get(AnimationPlayHead, EditorSkin.Game);
        public static GUIStyle AnimationPlayHead_Inspector => Get(AnimationPlayHead, EditorSkin.Inspector);
        public static GUIStyle AnimationPlayHead_Scene => Get(AnimationPlayHead, EditorSkin.Scene);
        public const string AnimationRowEven = "AnimationRowEven";
        public static GUIStyle AnimationRowEven_Game => Get(AnimationRowEven, EditorSkin.Game);
        public static GUIStyle AnimationRowEven_Inspector => Get(AnimationRowEven, EditorSkin.Inspector);
        public static GUIStyle AnimationRowEven_Scene => Get(AnimationRowEven, EditorSkin.Scene);
        public const string AnimationRowOdd = "AnimationRowOdd";
        public static GUIStyle AnimationRowOdd_Game => Get(AnimationRowOdd, EditorSkin.Game);
        public static GUIStyle AnimationRowOdd_Inspector => Get(AnimationRowOdd, EditorSkin.Inspector);
        public static GUIStyle AnimationRowOdd_Scene => Get(AnimationRowOdd, EditorSkin.Scene);
        public const string AnimationSelectionTextField = "AnimationSelectionTextField";
        public static GUIStyle AnimationSelectionTextField_Game => Get(AnimationSelectionTextField, EditorSkin.Game);

        public static GUIStyle AnimationSelectionTextField_Inspector =>
            Get(AnimationSelectionTextField, EditorSkin.Inspector);

        public static GUIStyle AnimationSelectionTextField_Scene => Get(AnimationSelectionTextField, EditorSkin.Scene);
        public const string AnimationTimelineTick = "AnimationTimelineTick";
        public static GUIStyle AnimationTimelineTick_Game => Get(AnimationTimelineTick, EditorSkin.Game);
        public static GUIStyle AnimationTimelineTick_Inspector => Get(AnimationTimelineTick, EditorSkin.Inspector);
        public static GUIStyle AnimationTimelineTick_Scene => Get(AnimationTimelineTick, EditorSkin.Scene);
        public const string AnimClipToolbar = "AnimClipToolbar";
        public static GUIStyle AnimClipToolbar_Game => Get(AnimClipToolbar, EditorSkin.Game);
        public static GUIStyle AnimClipToolbar_Inspector => Get(AnimClipToolbar, EditorSkin.Inspector);
        public static GUIStyle AnimClipToolbar_Scene => Get(AnimClipToolbar, EditorSkin.Scene);
        public const string AnimClipToolbarButton = "AnimClipToolbarButton";
        public static GUIStyle AnimClipToolbarButton_Game => Get(AnimClipToolbarButton, EditorSkin.Game);
        public static GUIStyle AnimClipToolbarButton_Inspector => Get(AnimClipToolbarButton, EditorSkin.Inspector);
        public static GUIStyle AnimClipToolbarButton_Scene => Get(AnimClipToolbarButton, EditorSkin.Scene);
        public const string AnimClipToolbarPopup = "AnimClipToolbarPopup";
        public static GUIStyle AnimClipToolbarPopup_Game => Get(AnimClipToolbarPopup, EditorSkin.Game);
        public static GUIStyle AnimClipToolbarPopup_Inspector => Get(AnimClipToolbarPopup, EditorSkin.Inspector);
        public static GUIStyle AnimClipToolbarPopup_Scene => Get(AnimClipToolbarPopup, EditorSkin.Scene);
        public const string AnimItemBackground = "AnimItemBackground";
        public static GUIStyle AnimItemBackground_Game => Get(AnimItemBackground, EditorSkin.Game);
        public static GUIStyle AnimItemBackground_Inspector => Get(AnimItemBackground, EditorSkin.Inspector);
        public static GUIStyle AnimItemBackground_Scene => Get(AnimItemBackground, EditorSkin.Scene);
        public const string AnimLeftPaneSeparator = "AnimLeftPaneSeparator";
        public static GUIStyle AnimLeftPaneSeparator_Game => Get(AnimLeftPaneSeparator, EditorSkin.Game);
        public static GUIStyle AnimLeftPaneSeparator_Inspector => Get(AnimLeftPaneSeparator, EditorSkin.Inspector);
        public static GUIStyle AnimLeftPaneSeparator_Scene => Get(AnimLeftPaneSeparator, EditorSkin.Scene);
        public const string AnimPlayToolbar = "AnimPlayToolbar";
        public static GUIStyle AnimPlayToolbar_Game => Get(AnimPlayToolbar, EditorSkin.Game);
        public static GUIStyle AnimPlayToolbar_Inspector => Get(AnimPlayToolbar, EditorSkin.Inspector);
        public static GUIStyle AnimPlayToolbar_Scene => Get(AnimPlayToolbar, EditorSkin.Scene);
        public const string AnimPropDropdown = "AnimPropDropdown";
        public static GUIStyle AnimPropDropdown_Game => Get(AnimPropDropdown, EditorSkin.Game);
        public static GUIStyle AnimPropDropdown_Inspector => Get(AnimPropDropdown, EditorSkin.Inspector);
        public static GUIStyle AnimPropDropdown_Scene => Get(AnimPropDropdown, EditorSkin.Scene);
        public const string AppCommand = "AppCommand";
        public static GUIStyle AppCommand_Game => Get(AppCommand, EditorSkin.Game);
        public static GUIStyle AppCommand_Inspector => Get(AppCommand, EditorSkin.Inspector);
        public static GUIStyle AppCommand_Scene => Get(AppCommand, EditorSkin.Scene);
        public const string AppCommandLeft = "AppCommandLeft";
        public static GUIStyle AppCommandLeft_Game => Get(AppCommandLeft, EditorSkin.Game);
        public static GUIStyle AppCommandLeft_Inspector => Get(AppCommandLeft, EditorSkin.Inspector);
        public static GUIStyle AppCommandLeft_Scene => Get(AppCommandLeft, EditorSkin.Scene);
        public const string AppCommandLeftOn = "AppCommandLeftOn";
        public static GUIStyle AppCommandLeftOn_Game => Get(AppCommandLeftOn, EditorSkin.Game);
        public static GUIStyle AppCommandLeftOn_Inspector => Get(AppCommandLeftOn, EditorSkin.Inspector);
        public static GUIStyle AppCommandLeftOn_Scene => Get(AppCommandLeftOn, EditorSkin.Scene);
        public const string AppCommandMid = "AppCommandMid";
        public static GUIStyle AppCommandMid_Game => Get(AppCommandMid, EditorSkin.Game);
        public static GUIStyle AppCommandMid_Inspector => Get(AppCommandMid, EditorSkin.Inspector);
        public static GUIStyle AppCommandMid_Scene => Get(AppCommandMid, EditorSkin.Scene);
        public const string AppCommandRight = "AppCommandRight";
        public static GUIStyle AppCommandRight_Game => Get(AppCommandRight, EditorSkin.Game);
        public static GUIStyle AppCommandRight_Inspector => Get(AppCommandRight, EditorSkin.Inspector);
        public static GUIStyle AppCommandRight_Scene => Get(AppCommandRight, EditorSkin.Scene);
        public const string AppToolbar = "AppToolbar";
        public static GUIStyle AppToolbar_Game => Get(AppToolbar, EditorSkin.Game);
        public static GUIStyle AppToolbar_Inspector => Get(AppToolbar, EditorSkin.Inspector);
        public static GUIStyle AppToolbar_Scene => Get(AppToolbar, EditorSkin.Scene);
        public const string AppToolbarButtonLeft = "AppToolbarButtonLeft";
        public static GUIStyle AppToolbarButtonLeft_Game => Get(AppToolbarButtonLeft, EditorSkin.Game);
        public static GUIStyle AppToolbarButtonLeft_Inspector => Get(AppToolbarButtonLeft, EditorSkin.Inspector);
        public static GUIStyle AppToolbarButtonLeft_Scene => Get(AppToolbarButtonLeft, EditorSkin.Scene);
        public const string AppToolbarButtonMid = "AppToolbarButtonMid";
        public static GUIStyle AppToolbarButtonMid_Game => Get(AppToolbarButtonMid, EditorSkin.Game);
        public static GUIStyle AppToolbarButtonMid_Inspector => Get(AppToolbarButtonMid, EditorSkin.Inspector);
        public static GUIStyle AppToolbarButtonMid_Scene => Get(AppToolbarButtonMid, EditorSkin.Scene);
        public const string AppToolbarButtonRight = "AppToolbarButtonRight";
        public static GUIStyle AppToolbarButtonRight_Game => Get(AppToolbarButtonRight, EditorSkin.Game);
        public static GUIStyle AppToolbarButtonRight_Inspector => Get(AppToolbarButtonRight, EditorSkin.Inspector);
        public static GUIStyle AppToolbarButtonRight_Scene => Get(AppToolbarButtonRight, EditorSkin.Scene);
        public const string ArrowNavigationLeft = "ArrowNavigationLeft";
        public static GUIStyle ArrowNavigationLeft_Game => Get(ArrowNavigationLeft, EditorSkin.Game);
        public static GUIStyle ArrowNavigationLeft_Inspector => Get(ArrowNavigationLeft, EditorSkin.Inspector);
        public static GUIStyle ArrowNavigationLeft_Scene => Get(ArrowNavigationLeft, EditorSkin.Scene);
        public const string ArrowNavigationRight = "ArrowNavigationRight";
        public static GUIStyle ArrowNavigationRight_Game => Get(ArrowNavigationRight, EditorSkin.Game);
        public static GUIStyle ArrowNavigationRight_Inspector => Get(ArrowNavigationRight, EditorSkin.Inspector);
        public static GUIStyle ArrowNavigationRight_Scene => Get(ArrowNavigationRight, EditorSkin.Scene);
        public const string AssetLabel = "AssetLabel";
        public static GUIStyle AssetLabel_Game => Get(AssetLabel, EditorSkin.Game);
        public static GUIStyle AssetLabel_Inspector => Get(AssetLabel, EditorSkin.Inspector);
        public static GUIStyle AssetLabel_Scene => Get(AssetLabel, EditorSkin.Scene);
        public const string AssetLabel_Icon = "AssetLabel Icon";
        public static GUIStyle AssetLabel_Icon_Game => Get(AssetLabel_Icon, EditorSkin.Game);
        public static GUIStyle AssetLabel_Icon_Inspector => Get(AssetLabel_Icon, EditorSkin.Inspector);
        public static GUIStyle AssetLabel_Icon_Scene => Get(AssetLabel_Icon, EditorSkin.Scene);
        public const string AssetLabel_Partial = "AssetLabel Partial";
        public static GUIStyle AssetLabel_Partial_Game => Get(AssetLabel_Partial, EditorSkin.Game);
        public static GUIStyle AssetLabel_Partial_Inspector => Get(AssetLabel_Partial, EditorSkin.Inspector);
        public static GUIStyle AssetLabel_Partial_Scene => Get(AssetLabel_Partial, EditorSkin.Scene);
        public const string AvatarMappingBox = "AvatarMappingBox";
        public static GUIStyle AvatarMappingBox_Game => Get(AvatarMappingBox, EditorSkin.Game);
        public static GUIStyle AvatarMappingBox_Inspector => Get(AvatarMappingBox, EditorSkin.Inspector);
        public static GUIStyle AvatarMappingBox_Scene => Get(AvatarMappingBox, EditorSkin.Scene);
        public const string AvatarMappingErrorLabel = "AvatarMappingErrorLabel";
        public static GUIStyle AvatarMappingErrorLabel_Game => Get(AvatarMappingErrorLabel, EditorSkin.Game);
        public static GUIStyle AvatarMappingErrorLabel_Inspector => Get(AvatarMappingErrorLabel, EditorSkin.Inspector);
        public static GUIStyle AvatarMappingErrorLabel_Scene => Get(AvatarMappingErrorLabel, EditorSkin.Scene);
        public const string AxisLabelNumberField = "AxisLabelNumberField";
        public static GUIStyle AxisLabelNumberField_Game => Get(AxisLabelNumberField, EditorSkin.Game);
        public static GUIStyle AxisLabelNumberField_Inspector => Get(AxisLabelNumberField, EditorSkin.Inspector);
        public static GUIStyle AxisLabelNumberField_Scene => Get(AxisLabelNumberField, EditorSkin.Scene);
        public const string Badge = "Badge";
        public static GUIStyle Badge_Game => Get(Badge, EditorSkin.Game);
        public static GUIStyle Badge_Inspector => Get(Badge, EditorSkin.Inspector);
        public static GUIStyle Badge_Scene => Get(Badge, EditorSkin.Scene);
        public const string BoldLabel = "BoldLabel";
        public static GUIStyle BoldLabel_Game => Get(BoldLabel, EditorSkin.Game);
        public static GUIStyle BoldLabel_Inspector => Get(BoldLabel, EditorSkin.Inspector);
        public static GUIStyle BoldLabel_Scene => Get(BoldLabel, EditorSkin.Scene);
        public const string BoldTextField = "BoldTextField";
        public static GUIStyle BoldTextField_Game => Get(BoldTextField, EditorSkin.Game);
        public static GUIStyle BoldTextField_Inspector => Get(BoldTextField, EditorSkin.Inspector);
        public static GUIStyle BoldTextField_Scene => Get(BoldTextField, EditorSkin.Scene);
        public const string BoldToggle = "BoldToggle";
        public static GUIStyle BoldToggle_Game => Get(BoldToggle, EditorSkin.Game);
        public static GUIStyle BoldToggle_Inspector => Get(BoldToggle, EditorSkin.Inspector);
        public static GUIStyle BoldToggle_Scene => Get(BoldToggle, EditorSkin.Scene);
        public const string BottomShadowInwards = "BottomShadowInwards";
        public static GUIStyle BottomShadowInwards_Game => Get(BottomShadowInwards, EditorSkin.Game);
        public static GUIStyle BottomShadowInwards_Inspector => Get(BottomShadowInwards, EditorSkin.Inspector);
        public static GUIStyle BottomShadowInwards_Scene => Get(BottomShadowInwards, EditorSkin.Scene);
        public const string BreadcrumbsSeparator = "BreadcrumbsSeparator";
        public static GUIStyle BreadcrumbsSeparator_Game => Get(BreadcrumbsSeparator, EditorSkin.Game);
        public static GUIStyle BreadcrumbsSeparator_Inspector => Get(BreadcrumbsSeparator, EditorSkin.Inspector);
        public static GUIStyle BreadcrumbsSeparator_Scene => Get(BreadcrumbsSeparator, EditorSkin.Scene);
        public const string ButtonLeft = "ButtonLeft";
        public static GUIStyle ButtonLeft_Game => Get(ButtonLeft, EditorSkin.Game);
        public static GUIStyle ButtonLeft_Inspector => Get(ButtonLeft, EditorSkin.Inspector);
        public static GUIStyle ButtonLeft_Scene => Get(ButtonLeft, EditorSkin.Scene);
        public const string ButtonMid = "ButtonMid";
        public static GUIStyle ButtonMid_Game => Get(ButtonMid, EditorSkin.Game);
        public static GUIStyle ButtonMid_Inspector => Get(ButtonMid, EditorSkin.Inspector);
        public static GUIStyle ButtonMid_Scene => Get(ButtonMid, EditorSkin.Scene);
        public const string ButtonRight = "ButtonRight";
        public static GUIStyle ButtonRight_Game => Get(ButtonRight, EditorSkin.Game);
        public static GUIStyle ButtonRight_Inspector => Get(ButtonRight, EditorSkin.Inspector);
        public static GUIStyle ButtonRight_Scene => Get(ButtonRight, EditorSkin.Scene);
        public const string BypassToggle = "BypassToggle";
        public static GUIStyle BypassToggle_Game => Get(BypassToggle, EditorSkin.Game);
        public static GUIStyle BypassToggle_Inspector => Get(BypassToggle, EditorSkin.Inspector);
        public static GUIStyle BypassToggle_Scene => Get(BypassToggle, EditorSkin.Scene);
        public const string CacheFolderLocation = "CacheFolderLocation";
        public static GUIStyle CacheFolderLocation_Game => Get(CacheFolderLocation, EditorSkin.Game);
        public static GUIStyle CacheFolderLocation_Inspector => Get(CacheFolderLocation, EditorSkin.Inspector);
        public static GUIStyle CacheFolderLocation_Scene => Get(CacheFolderLocation, EditorSkin.Scene);
        public const string CenteredLabel = "CenteredLabel";
        public static GUIStyle CenteredLabel_Game => Get(CenteredLabel, EditorSkin.Game);
        public static GUIStyle CenteredLabel_Inspector => Get(CenteredLabel, EditorSkin.Inspector);
        public static GUIStyle CenteredLabel_Scene => Get(CenteredLabel, EditorSkin.Scene);
        public const string ChannelStripAttenuationBar = "ChannelStripAttenuationBar";
        public static GUIStyle ChannelStripAttenuationBar_Game => Get(ChannelStripAttenuationBar, EditorSkin.Game);

        public static GUIStyle ChannelStripAttenuationBar_Inspector =>
            Get(ChannelStripAttenuationBar, EditorSkin.Inspector);

        public static GUIStyle ChannelStripAttenuationBar_Scene => Get(ChannelStripAttenuationBar, EditorSkin.Scene);
        public const string ChannelStripAttenuationMarkerSquare = "ChannelStripAttenuationMarkerSquare";

        public static GUIStyle ChannelStripAttenuationMarkerSquare_Game =>
            Get(ChannelStripAttenuationMarkerSquare, EditorSkin.Game);

        public static GUIStyle ChannelStripAttenuationMarkerSquare_Inspector =>
            Get(ChannelStripAttenuationMarkerSquare, EditorSkin.Inspector);

        public static GUIStyle ChannelStripAttenuationMarkerSquare_Scene =>
            Get(ChannelStripAttenuationMarkerSquare, EditorSkin.Scene);

        public const string ChannelStripBg = "ChannelStripBg";
        public static GUIStyle ChannelStripBg_Game => Get(ChannelStripBg, EditorSkin.Game);
        public static GUIStyle ChannelStripBg_Inspector => Get(ChannelStripBg, EditorSkin.Inspector);
        public static GUIStyle ChannelStripBg_Scene => Get(ChannelStripBg, EditorSkin.Scene);
        public const string ChannelStripDuckingMarker = "ChannelStripDuckingMarker";
        public static GUIStyle ChannelStripDuckingMarker_Game => Get(ChannelStripDuckingMarker, EditorSkin.Game);

        public static GUIStyle ChannelStripDuckingMarker_Inspector =>
            Get(ChannelStripDuckingMarker, EditorSkin.Inspector);

        public static GUIStyle ChannelStripDuckingMarker_Scene => Get(ChannelStripDuckingMarker, EditorSkin.Scene);
        public const string ChannelStripEffectBar = "ChannelStripEffectBar";
        public static GUIStyle ChannelStripEffectBar_Game => Get(ChannelStripEffectBar, EditorSkin.Game);
        public static GUIStyle ChannelStripEffectBar_Inspector => Get(ChannelStripEffectBar, EditorSkin.Inspector);
        public static GUIStyle ChannelStripEffectBar_Scene => Get(ChannelStripEffectBar, EditorSkin.Scene);
        public const string ChannelStripSendReturnBar = "ChannelStripSendReturnBar";
        public static GUIStyle ChannelStripSendReturnBar_Game => Get(ChannelStripSendReturnBar, EditorSkin.Game);

        public static GUIStyle ChannelStripSendReturnBar_Inspector =>
            Get(ChannelStripSendReturnBar, EditorSkin.Inspector);

        public static GUIStyle ChannelStripSendReturnBar_Scene => Get(ChannelStripSendReturnBar, EditorSkin.Scene);
        public const string ChannelStripVUMeterBg = "ChannelStripVUMeterBg";
        public static GUIStyle ChannelStripVUMeterBg_Game => Get(ChannelStripVUMeterBg, EditorSkin.Game);
        public static GUIStyle ChannelStripVUMeterBg_Inspector => Get(ChannelStripVUMeterBg, EditorSkin.Inspector);
        public static GUIStyle ChannelStripVUMeterBg_Scene => Get(ChannelStripVUMeterBg, EditorSkin.Scene);
        public const string CircularToggle = "CircularToggle";
        public static GUIStyle CircularToggle_Game => Get(CircularToggle, EditorSkin.Game);
        public static GUIStyle CircularToggle_Inspector => Get(CircularToggle, EditorSkin.Inspector);
        public static GUIStyle CircularToggle_Scene => Get(CircularToggle, EditorSkin.Scene);
        public const string CN_Box = "CN Box";
        public static GUIStyle CN_Box_Game => Get(CN_Box, EditorSkin.Game);
        public static GUIStyle CN_Box_Inspector => Get(CN_Box, EditorSkin.Inspector);
        public static GUIStyle CN_Box_Scene => Get(CN_Box, EditorSkin.Scene);
        public const string CN_CenteredText = "CN CenteredText";
        public static GUIStyle CN_CenteredText_Game => Get(CN_CenteredText, EditorSkin.Game);
        public static GUIStyle CN_CenteredText_Inspector => Get(CN_CenteredText, EditorSkin.Inspector);
        public static GUIStyle CN_CenteredText_Scene => Get(CN_CenteredText, EditorSkin.Scene);
        public const string CN_CountBadge = "CN CountBadge";
        public static GUIStyle CN_CountBadge_Game => Get(CN_CountBadge, EditorSkin.Game);
        public static GUIStyle CN_CountBadge_Inspector => Get(CN_CountBadge, EditorSkin.Inspector);
        public static GUIStyle CN_CountBadge_Scene => Get(CN_CountBadge, EditorSkin.Scene);
        public const string CN_EntryBackEven = "CN EntryBackEven";
        public static GUIStyle CN_EntryBackEven_Game => Get(CN_EntryBackEven, EditorSkin.Game);
        public static GUIStyle CN_EntryBackEven_Inspector => Get(CN_EntryBackEven, EditorSkin.Inspector);
        public static GUIStyle CN_EntryBackEven_Scene => Get(CN_EntryBackEven, EditorSkin.Scene);
        public const string CN_EntryBackOdd = "CN EntryBackOdd";
        public static GUIStyle CN_EntryBackOdd_Game => Get(CN_EntryBackOdd, EditorSkin.Game);
        public static GUIStyle CN_EntryBackOdd_Inspector => Get(CN_EntryBackOdd, EditorSkin.Inspector);
        public static GUIStyle CN_EntryBackOdd_Scene => Get(CN_EntryBackOdd, EditorSkin.Scene);
        public const string CN_EntryError = "CN EntryError";
        public static GUIStyle CN_EntryError_Game => Get(CN_EntryError, EditorSkin.Game);
        public static GUIStyle CN_EntryError_Inspector => Get(CN_EntryError, EditorSkin.Inspector);
        public static GUIStyle CN_EntryError_Scene => Get(CN_EntryError, EditorSkin.Scene);
        public const string CN_EntryErrorIcon = "CN EntryErrorIcon";
        public static GUIStyle CN_EntryErrorIcon_Game => Get(CN_EntryErrorIcon, EditorSkin.Game);
        public static GUIStyle CN_EntryErrorIcon_Inspector => Get(CN_EntryErrorIcon, EditorSkin.Inspector);
        public static GUIStyle CN_EntryErrorIcon_Scene => Get(CN_EntryErrorIcon, EditorSkin.Scene);
        public const string CN_EntryErrorIconSmall = "CN EntryErrorIconSmall";
        public static GUIStyle CN_EntryErrorIconSmall_Game => Get(CN_EntryErrorIconSmall, EditorSkin.Game);
        public static GUIStyle CN_EntryErrorIconSmall_Inspector => Get(CN_EntryErrorIconSmall, EditorSkin.Inspector);
        public static GUIStyle CN_EntryErrorIconSmall_Scene => Get(CN_EntryErrorIconSmall, EditorSkin.Scene);
        public const string CN_EntryErrorSmall = "CN EntryErrorSmall";
        public static GUIStyle CN_EntryErrorSmall_Game => Get(CN_EntryErrorSmall, EditorSkin.Game);
        public static GUIStyle CN_EntryErrorSmall_Inspector => Get(CN_EntryErrorSmall, EditorSkin.Inspector);
        public static GUIStyle CN_EntryErrorSmall_Scene => Get(CN_EntryErrorSmall, EditorSkin.Scene);
        public const string CN_EntryInfo = "CN EntryInfo";
        public static GUIStyle CN_EntryInfo_Game => Get(CN_EntryInfo, EditorSkin.Game);
        public static GUIStyle CN_EntryInfo_Inspector => Get(CN_EntryInfo, EditorSkin.Inspector);
        public static GUIStyle CN_EntryInfo_Scene => Get(CN_EntryInfo, EditorSkin.Scene);
        public const string CN_EntryInfoIcon = "CN EntryInfoIcon";
        public static GUIStyle CN_EntryInfoIcon_Game => Get(CN_EntryInfoIcon, EditorSkin.Game);
        public static GUIStyle CN_EntryInfoIcon_Inspector => Get(CN_EntryInfoIcon, EditorSkin.Inspector);
        public static GUIStyle CN_EntryInfoIcon_Scene => Get(CN_EntryInfoIcon, EditorSkin.Scene);
        public const string CN_EntryInfoIconSmall = "CN EntryInfoIconSmall";
        public static GUIStyle CN_EntryInfoIconSmall_Game => Get(CN_EntryInfoIconSmall, EditorSkin.Game);
        public static GUIStyle CN_EntryInfoIconSmall_Inspector => Get(CN_EntryInfoIconSmall, EditorSkin.Inspector);
        public static GUIStyle CN_EntryInfoIconSmall_Scene => Get(CN_EntryInfoIconSmall, EditorSkin.Scene);
        public const string CN_EntryInfoSmall = "CN EntryInfoSmall";
        public static GUIStyle CN_EntryInfoSmall_Game => Get(CN_EntryInfoSmall, EditorSkin.Game);
        public static GUIStyle CN_EntryInfoSmall_Inspector => Get(CN_EntryInfoSmall, EditorSkin.Inspector);
        public static GUIStyle CN_EntryInfoSmall_Scene => Get(CN_EntryInfoSmall, EditorSkin.Scene);
        public const string CN_EntryWarn = "CN EntryWarn";
        public static GUIStyle CN_EntryWarn_Game => Get(CN_EntryWarn, EditorSkin.Game);
        public static GUIStyle CN_EntryWarn_Inspector => Get(CN_EntryWarn, EditorSkin.Inspector);
        public static GUIStyle CN_EntryWarn_Scene => Get(CN_EntryWarn, EditorSkin.Scene);
        public const string CN_EntryWarnIcon = "CN EntryWarnIcon";
        public static GUIStyle CN_EntryWarnIcon_Game => Get(CN_EntryWarnIcon, EditorSkin.Game);
        public static GUIStyle CN_EntryWarnIcon_Inspector => Get(CN_EntryWarnIcon, EditorSkin.Inspector);
        public static GUIStyle CN_EntryWarnIcon_Scene => Get(CN_EntryWarnIcon, EditorSkin.Scene);
        public const string CN_EntryWarnIconSmall = "CN EntryWarnIconSmall";
        public static GUIStyle CN_EntryWarnIconSmall_Game => Get(CN_EntryWarnIconSmall, EditorSkin.Game);
        public static GUIStyle CN_EntryWarnIconSmall_Inspector => Get(CN_EntryWarnIconSmall, EditorSkin.Inspector);
        public static GUIStyle CN_EntryWarnIconSmall_Scene => Get(CN_EntryWarnIconSmall, EditorSkin.Scene);
        public const string CN_EntryWarnSmall = "CN EntryWarnSmall";
        public static GUIStyle CN_EntryWarnSmall_Game => Get(CN_EntryWarnSmall, EditorSkin.Game);
        public static GUIStyle CN_EntryWarnSmall_Inspector => Get(CN_EntryWarnSmall, EditorSkin.Inspector);
        public static GUIStyle CN_EntryWarnSmall_Scene => Get(CN_EntryWarnSmall, EditorSkin.Scene);
        public const string CN_Message = "CN Message";
        public static GUIStyle CN_Message_Game => Get(CN_Message, EditorSkin.Game);
        public static GUIStyle CN_Message_Inspector => Get(CN_Message, EditorSkin.Inspector);
        public static GUIStyle CN_Message_Scene => Get(CN_Message, EditorSkin.Scene);
        public const string CN_StacktraceBackground = "CN StacktraceBackground";
        public static GUIStyle CN_StacktraceBackground_Game => Get(CN_StacktraceBackground, EditorSkin.Game);
        public static GUIStyle CN_StacktraceBackground_Inspector => Get(CN_StacktraceBackground, EditorSkin.Inspector);
        public static GUIStyle CN_StacktraceBackground_Scene => Get(CN_StacktraceBackground, EditorSkin.Scene);
        public const string CN_StacktraceStyle = "CN StacktraceStyle";
        public static GUIStyle CN_StacktraceStyle_Game => Get(CN_StacktraceStyle, EditorSkin.Game);
        public static GUIStyle CN_StacktraceStyle_Inspector => Get(CN_StacktraceStyle, EditorSkin.Inspector);
        public static GUIStyle CN_StacktraceStyle_Scene => Get(CN_StacktraceStyle, EditorSkin.Scene);
        public const string CN_StatusError = "CN StatusError";
        public static GUIStyle CN_StatusError_Game => Get(CN_StatusError, EditorSkin.Game);
        public static GUIStyle CN_StatusError_Inspector => Get(CN_StatusError, EditorSkin.Inspector);
        public static GUIStyle CN_StatusError_Scene => Get(CN_StatusError, EditorSkin.Scene);
        public const string CN_StatusInfo = "CN StatusInfo";
        public static GUIStyle CN_StatusInfo_Game => Get(CN_StatusInfo, EditorSkin.Game);
        public static GUIStyle CN_StatusInfo_Inspector => Get(CN_StatusInfo, EditorSkin.Inspector);
        public static GUIStyle CN_StatusInfo_Scene => Get(CN_StatusInfo, EditorSkin.Scene);
        public const string CN_StatusWarn = "CN StatusWarn";
        public static GUIStyle CN_StatusWarn_Game => Get(CN_StatusWarn, EditorSkin.Game);
        public static GUIStyle CN_StatusWarn_Inspector => Get(CN_StatusWarn, EditorSkin.Inspector);
        public static GUIStyle CN_StatusWarn_Scene => Get(CN_StatusWarn, EditorSkin.Scene);
        public const string ColorField = "ColorField";
        public static GUIStyle ColorField_Game => Get(ColorField, EditorSkin.Game);
        public static GUIStyle ColorField_Inspector => Get(ColorField, EditorSkin.Inspector);
        public static GUIStyle ColorField_Scene => Get(ColorField, EditorSkin.Scene);
        public const string ColorPicker2DThumb = "ColorPicker2DThumb";
        public static GUIStyle ColorPicker2DThumb_Game => Get(ColorPicker2DThumb, EditorSkin.Game);
        public static GUIStyle ColorPicker2DThumb_Inspector => Get(ColorPicker2DThumb, EditorSkin.Inspector);
        public static GUIStyle ColorPicker2DThumb_Scene => Get(ColorPicker2DThumb, EditorSkin.Scene);
        public const string ColorPickerBackground = "ColorPickerBackground";
        public static GUIStyle ColorPickerBackground_Game => Get(ColorPickerBackground, EditorSkin.Game);
        public static GUIStyle ColorPickerBackground_Inspector => Get(ColorPickerBackground, EditorSkin.Inspector);
        public static GUIStyle ColorPickerBackground_Scene => Get(ColorPickerBackground, EditorSkin.Scene);
        public const string ColorPickerBox = "ColorPickerBox";
        public static GUIStyle ColorPickerBox_Game => Get(ColorPickerBox, EditorSkin.Game);
        public static GUIStyle ColorPickerBox_Inspector => Get(ColorPickerBox, EditorSkin.Inspector);
        public static GUIStyle ColorPickerBox_Scene => Get(ColorPickerBox, EditorSkin.Scene);
        public const string ColorPickerCurrentColor = "ColorPickerCurrentColor";
        public static GUIStyle ColorPickerCurrentColor_Game => Get(ColorPickerCurrentColor, EditorSkin.Game);
        public static GUIStyle ColorPickerCurrentColor_Inspector => Get(ColorPickerCurrentColor, EditorSkin.Inspector);
        public static GUIStyle ColorPickerCurrentColor_Scene => Get(ColorPickerCurrentColor, EditorSkin.Scene);
        public const string ColorPickerCurrentExposureSwatchBorder = "ColorPickerCurrentExposureSwatchBorder";

        public static GUIStyle ColorPickerCurrentExposureSwatchBorder_Game =>
            Get(ColorPickerCurrentExposureSwatchBorder, EditorSkin.Game);

        public static GUIStyle ColorPickerCurrentExposureSwatchBorder_Inspector =>
            Get(ColorPickerCurrentExposureSwatchBorder, EditorSkin.Inspector);

        public static GUIStyle ColorPickerCurrentExposureSwatchBorder_Scene =>
            Get(ColorPickerCurrentExposureSwatchBorder, EditorSkin.Scene);

        public const string ColorPickerExposureSwatch = "ColorPickerExposureSwatch";
        public static GUIStyle ColorPickerExposureSwatch_Game => Get(ColorPickerExposureSwatch, EditorSkin.Game);

        public static GUIStyle ColorPickerExposureSwatch_Inspector =>
            Get(ColorPickerExposureSwatch, EditorSkin.Inspector);

        public static GUIStyle ColorPickerExposureSwatch_Scene => Get(ColorPickerExposureSwatch, EditorSkin.Scene);
        public const string ColorPickerHorizThumb = "ColorPickerHorizThumb";
        public static GUIStyle ColorPickerHorizThumb_Game => Get(ColorPickerHorizThumb, EditorSkin.Game);
        public static GUIStyle ColorPickerHorizThumb_Inspector => Get(ColorPickerHorizThumb, EditorSkin.Inspector);
        public static GUIStyle ColorPickerHorizThumb_Scene => Get(ColorPickerHorizThumb, EditorSkin.Scene);
        public const string ColorPickerHueRing = "ColorPickerHueRing";
        public static GUIStyle ColorPickerHueRing_Game => Get(ColorPickerHueRing, EditorSkin.Game);
        public static GUIStyle ColorPickerHueRing_Inspector => Get(ColorPickerHueRing, EditorSkin.Inspector);
        public static GUIStyle ColorPickerHueRing_Scene => Get(ColorPickerHueRing, EditorSkin.Scene);
        public const string ColorPickerHueRing_HDR = "ColorPickerHueRing HDR";
        public static GUIStyle ColorPickerHueRing_HDR_Game => Get(ColorPickerHueRing_HDR, EditorSkin.Game);
        public static GUIStyle ColorPickerHueRing_HDR_Inspector => Get(ColorPickerHueRing_HDR, EditorSkin.Inspector);
        public static GUIStyle ColorPickerHueRing_HDR_Scene => Get(ColorPickerHueRing_HDR, EditorSkin.Scene);
        public const string ColorPickerHueRingThumb = "ColorPickerHueRingThumb";
        public static GUIStyle ColorPickerHueRingThumb_Game => Get(ColorPickerHueRingThumb, EditorSkin.Game);
        public static GUIStyle ColorPickerHueRingThumb_Inspector => Get(ColorPickerHueRingThumb, EditorSkin.Inspector);
        public static GUIStyle ColorPickerHueRingThumb_Scene => Get(ColorPickerHueRingThumb, EditorSkin.Scene);
        public const string ColorPickerOriginalColor = "ColorPickerOriginalColor";
        public static GUIStyle ColorPickerOriginalColor_Game => Get(ColorPickerOriginalColor, EditorSkin.Game);

        public static GUIStyle ColorPickerOriginalColor_Inspector =>
            Get(ColorPickerOriginalColor, EditorSkin.Inspector);

        public static GUIStyle ColorPickerOriginalColor_Scene => Get(ColorPickerOriginalColor, EditorSkin.Scene);
        public const string ColorPickerSliderBackground = "ColorPickerSliderBackground";
        public static GUIStyle ColorPickerSliderBackground_Game => Get(ColorPickerSliderBackground, EditorSkin.Game);

        public static GUIStyle ColorPickerSliderBackground_Inspector =>
            Get(ColorPickerSliderBackground, EditorSkin.Inspector);

        public static GUIStyle ColorPickerSliderBackground_Scene => Get(ColorPickerSliderBackground, EditorSkin.Scene);
        public const string Command = "Command";
        public static GUIStyle Command_Game => Get(Command, EditorSkin.Game);
        public static GUIStyle Command_Inspector => Get(Command, EditorSkin.Inspector);
        public static GUIStyle Command_Scene => Get(Command, EditorSkin.Scene);
        public const string CommandLeft = "CommandLeft";
        public static GUIStyle CommandLeft_Game => Get(CommandLeft, EditorSkin.Game);
        public static GUIStyle CommandLeft_Inspector => Get(CommandLeft, EditorSkin.Inspector);
        public static GUIStyle CommandLeft_Scene => Get(CommandLeft, EditorSkin.Scene);
        public const string CommandMid = "CommandMid";
        public static GUIStyle CommandMid_Game => Get(CommandMid, EditorSkin.Game);
        public static GUIStyle CommandMid_Inspector => Get(CommandMid, EditorSkin.Inspector);
        public static GUIStyle CommandMid_Scene => Get(CommandMid, EditorSkin.Scene);
        public const string CommandRight = "CommandRight";
        public static GUIStyle CommandRight_Game => Get(CommandRight, EditorSkin.Game);
        public static GUIStyle CommandRight_Inspector => Get(CommandRight, EditorSkin.Inspector);
        public static GUIStyle CommandRight_Scene => Get(CommandRight, EditorSkin.Scene);
        public const string ContentToolbar = "ContentToolbar";
        public static GUIStyle ContentToolbar_Game => Get(ContentToolbar, EditorSkin.Game);
        public static GUIStyle ContentToolbar_Inspector => Get(ContentToolbar, EditorSkin.Inspector);
        public static GUIStyle ContentToolbar_Scene => Get(ContentToolbar, EditorSkin.Scene);
        public const string ControlHighlight = "ControlHighlight";
        public static GUIStyle ControlHighlight_Game => Get(ControlHighlight, EditorSkin.Game);
        public static GUIStyle ControlHighlight_Inspector => Get(ControlHighlight, EditorSkin.Inspector);
        public static GUIStyle ControlHighlight_Scene => Get(ControlHighlight, EditorSkin.Scene);
        public const string ControlLabel = "ControlLabel";
        public static GUIStyle ControlLabel_Game => Get(ControlLabel, EditorSkin.Game);
        public static GUIStyle ControlLabel_Inspector => Get(ControlLabel, EditorSkin.Inspector);
        public static GUIStyle ControlLabel_Scene => Get(ControlLabel, EditorSkin.Scene);
        public const string CurveEditorBackground = "CurveEditorBackground";
        public static GUIStyle CurveEditorBackground_Game => Get(CurveEditorBackground, EditorSkin.Game);
        public static GUIStyle CurveEditorBackground_Inspector => Get(CurveEditorBackground, EditorSkin.Inspector);
        public static GUIStyle CurveEditorBackground_Scene => Get(CurveEditorBackground, EditorSkin.Scene);
        public const string CurveEditorLabelTickmarks = "CurveEditorLabelTickmarks";
        public static GUIStyle CurveEditorLabelTickmarks_Game => Get(CurveEditorLabelTickmarks, EditorSkin.Game);

        public static GUIStyle CurveEditorLabelTickmarks_Inspector =>
            Get(CurveEditorLabelTickmarks, EditorSkin.Inspector);

        public static GUIStyle CurveEditorLabelTickmarks_Scene => Get(CurveEditorLabelTickmarks, EditorSkin.Scene);
        public const string CurveEditorLabelTickmarksOverflow = "CurveEditorLabelTickmarksOverflow";

        public static GUIStyle CurveEditorLabelTickmarksOverflow_Game =>
            Get(CurveEditorLabelTickmarksOverflow, EditorSkin.Game);

        public static GUIStyle CurveEditorLabelTickmarksOverflow_Inspector =>
            Get(CurveEditorLabelTickmarksOverflow, EditorSkin.Inspector);

        public static GUIStyle CurveEditorLabelTickmarksOverflow_Scene =>
            Get(CurveEditorLabelTickmarksOverflow, EditorSkin.Scene);

        public const string CurveEditorRightAlignedLabel = "CurveEditorRightAlignedLabel";
        public static GUIStyle CurveEditorRightAlignedLabel_Game => Get(CurveEditorRightAlignedLabel, EditorSkin.Game);

        public static GUIStyle CurveEditorRightAlignedLabel_Inspector =>
            Get(CurveEditorRightAlignedLabel, EditorSkin.Inspector);

        public static GUIStyle CurveEditorRightAlignedLabel_Scene =>
            Get(CurveEditorRightAlignedLabel, EditorSkin.Scene);

        public const string DD_Background = "DD Background";
        public static GUIStyle DD_Background_Game => Get(DD_Background, EditorSkin.Game);
        public static GUIStyle DD_Background_Inspector => Get(DD_Background, EditorSkin.Inspector);
        public static GUIStyle DD_Background_Scene => Get(DD_Background, EditorSkin.Scene);
        public const string DD_HeaderStyle = "DD HeaderStyle";
        public static GUIStyle DD_HeaderStyle_Game => Get(DD_HeaderStyle, EditorSkin.Game);
        public static GUIStyle DD_HeaderStyle_Inspector => Get(DD_HeaderStyle, EditorSkin.Inspector);
        public static GUIStyle DD_HeaderStyle_Scene => Get(DD_HeaderStyle, EditorSkin.Scene);
        public const string DD_ItemCheckmark = "DD ItemCheckmark";
        public static GUIStyle DD_ItemCheckmark_Game => Get(DD_ItemCheckmark, EditorSkin.Game);
        public static GUIStyle DD_ItemCheckmark_Inspector => Get(DD_ItemCheckmark, EditorSkin.Inspector);
        public static GUIStyle DD_ItemCheckmark_Scene => Get(DD_ItemCheckmark, EditorSkin.Scene);
        public const string DD_ItemStyle = "DD ItemStyle";
        public static GUIStyle DD_ItemStyle_Game => Get(DD_ItemStyle, EditorSkin.Game);
        public static GUIStyle DD_ItemStyle_Inspector => Get(DD_ItemStyle, EditorSkin.Inspector);
        public static GUIStyle DD_ItemStyle_Scene => Get(DD_ItemStyle, EditorSkin.Scene);
        public const string DD_LargeItemStyle = "DD LargeItemStyle";
        public static GUIStyle DD_LargeItemStyle_Game => Get(DD_LargeItemStyle, EditorSkin.Game);
        public static GUIStyle DD_LargeItemStyle_Inspector => Get(DD_LargeItemStyle, EditorSkin.Inspector);
        public static GUIStyle DD_LargeItemStyle_Scene => Get(DD_LargeItemStyle, EditorSkin.Scene);
        public const string DefaultCenteredLargeText = "DefaultCenteredLargeText";
        public static GUIStyle DefaultCenteredLargeText_Game => Get(DefaultCenteredLargeText, EditorSkin.Game);

        public static GUIStyle DefaultCenteredLargeText_Inspector =>
            Get(DefaultCenteredLargeText, EditorSkin.Inspector);

        public static GUIStyle DefaultCenteredLargeText_Scene => Get(DefaultCenteredLargeText, EditorSkin.Scene);
        public const string DefaultCenteredText = "DefaultCenteredText";
        public static GUIStyle DefaultCenteredText_Game => Get(DefaultCenteredText, EditorSkin.Game);
        public static GUIStyle DefaultCenteredText_Inspector => Get(DefaultCenteredText, EditorSkin.Inspector);
        public static GUIStyle DefaultCenteredText_Scene => Get(DefaultCenteredText, EditorSkin.Scene);
        public const string DefaultLineSeparator = "DefaultLineSeparator";
        public static GUIStyle DefaultLineSeparator_Game => Get(DefaultLineSeparator, EditorSkin.Game);
        public static GUIStyle DefaultLineSeparator_Inspector => Get(DefaultLineSeparator, EditorSkin.Inspector);
        public static GUIStyle DefaultLineSeparator_Scene => Get(DefaultLineSeparator, EditorSkin.Scene);
        public const string dockarea = "dockarea";
        public static GUIStyle dockarea_Game => Get(dockarea, EditorSkin.Game);
        public static GUIStyle dockarea_Inspector => Get(dockarea, EditorSkin.Inspector);
        public static GUIStyle dockarea_Scene => Get(dockarea, EditorSkin.Scene);
        public const string dockareaOverlay = "dockareaOverlay";
        public static GUIStyle dockareaOverlay_Game => Get(dockareaOverlay, EditorSkin.Game);
        public static GUIStyle dockareaOverlay_Inspector => Get(dockareaOverlay, EditorSkin.Inspector);
        public static GUIStyle dockareaOverlay_Scene => Get(dockareaOverlay, EditorSkin.Scene);
        public const string dockareaStandalone = "dockareaStandalone";
        public static GUIStyle dockareaStandalone_Game => Get(dockareaStandalone, EditorSkin.Game);
        public static GUIStyle dockareaStandalone_Inspector => Get(dockareaStandalone, EditorSkin.Inspector);
        public static GUIStyle dockareaStandalone_Scene => Get(dockareaStandalone, EditorSkin.Scene);
        public const string dockHeader = "dockHeader";
        public static GUIStyle dockHeader_Game => Get(dockHeader, EditorSkin.Game);
        public static GUIStyle dockHeader_Inspector => Get(dockHeader, EditorSkin.Inspector);
        public static GUIStyle dockHeader_Scene => Get(dockHeader, EditorSkin.Scene);
        public const string DopesheetBackground = "DopesheetBackground";
        public static GUIStyle DopesheetBackground_Game => Get(DopesheetBackground, EditorSkin.Game);
        public static GUIStyle DopesheetBackground_Inspector => Get(DopesheetBackground, EditorSkin.Inspector);
        public static GUIStyle DopesheetBackground_Scene => Get(DopesheetBackground, EditorSkin.Scene);
        public const string Dopesheetkeyframe = "Dopesheetkeyframe";
        public static GUIStyle Dopesheetkeyframe_Game => Get(Dopesheetkeyframe, EditorSkin.Game);
        public static GUIStyle Dopesheetkeyframe_Inspector => Get(Dopesheetkeyframe, EditorSkin.Inspector);
        public static GUIStyle Dopesheetkeyframe_Scene => Get(Dopesheetkeyframe, EditorSkin.Scene);
        public const string DopesheetRippleLeft = "DopesheetRippleLeft";
        public static GUIStyle DopesheetRippleLeft_Game => Get(DopesheetRippleLeft, EditorSkin.Game);
        public static GUIStyle DopesheetRippleLeft_Inspector => Get(DopesheetRippleLeft, EditorSkin.Inspector);
        public static GUIStyle DopesheetRippleLeft_Scene => Get(DopesheetRippleLeft, EditorSkin.Scene);
        public const string DopesheetRippleRight = "DopesheetRippleRight";
        public static GUIStyle DopesheetRippleRight_Game => Get(DopesheetRippleRight, EditorSkin.Game);
        public static GUIStyle DopesheetRippleRight_Inspector => Get(DopesheetRippleRight, EditorSkin.Inspector);
        public static GUIStyle DopesheetRippleRight_Scene => Get(DopesheetRippleRight, EditorSkin.Scene);
        public const string DopesheetScaleLeft = "DopesheetScaleLeft";
        public static GUIStyle DopesheetScaleLeft_Game => Get(DopesheetScaleLeft, EditorSkin.Game);
        public static GUIStyle DopesheetScaleLeft_Inspector => Get(DopesheetScaleLeft, EditorSkin.Inspector);
        public static GUIStyle DopesheetScaleLeft_Scene => Get(DopesheetScaleLeft, EditorSkin.Scene);
        public const string DopesheetScaleRight = "DopesheetScaleRight";
        public static GUIStyle DopesheetScaleRight_Game => Get(DopesheetScaleRight, EditorSkin.Game);
        public static GUIStyle DopesheetScaleRight_Inspector => Get(DopesheetScaleRight, EditorSkin.Inspector);
        public static GUIStyle DopesheetScaleRight_Scene => Get(DopesheetScaleRight, EditorSkin.Scene);
        public const string dragtab = "dragtab";
        public static GUIStyle dragtab_Game => Get(dragtab, EditorSkin.Game);
        public static GUIStyle dragtab_Inspector => Get(dragtab, EditorSkin.Inspector);
        public static GUIStyle dragtab_Scene => Get(dragtab, EditorSkin.Scene);
        public const string dragtab_first = "dragtab first";
        public static GUIStyle dragtab_first_Game => Get(dragtab_first, EditorSkin.Game);
        public static GUIStyle dragtab_first_Inspector => Get(dragtab_first, EditorSkin.Inspector);
        public static GUIStyle dragtab_first_Scene => Get(dragtab_first, EditorSkin.Scene);
        public const string dragtab_scroller_next = "dragtab scroller next";
        public static GUIStyle dragtab_scroller_next_Game => Get(dragtab_scroller_next, EditorSkin.Game);
        public static GUIStyle dragtab_scroller_next_Inspector => Get(dragtab_scroller_next, EditorSkin.Inspector);
        public static GUIStyle dragtab_scroller_next_Scene => Get(dragtab_scroller_next, EditorSkin.Scene);
        public const string dragtab_scroller_prev = "dragtab scroller prev";
        public static GUIStyle dragtab_scroller_prev_Game => Get(dragtab_scroller_prev, EditorSkin.Game);
        public static GUIStyle dragtab_scroller_prev_Inspector => Get(dragtab_scroller_prev, EditorSkin.Inspector);
        public static GUIStyle dragtab_scroller_prev_Scene => Get(dragtab_scroller_prev, EditorSkin.Scene);
        public const string dragtabdropwindow = "dragtabdropwindow";
        public static GUIStyle dragtabdropwindow_Game => Get(dragtabdropwindow, EditorSkin.Game);
        public static GUIStyle dragtabdropwindow_Inspector => Get(dragtabdropwindow, EditorSkin.Inspector);
        public static GUIStyle dragtabdropwindow_Scene => Get(dragtabdropwindow, EditorSkin.Scene);
        public const string DropDown = "DropDown";
        public static GUIStyle DropDown_Game => Get(DropDown, EditorSkin.Game);
        public static GUIStyle DropDown_Inspector => Get(DropDown, EditorSkin.Inspector);
        public static GUIStyle DropDown_Scene => Get(DropDown, EditorSkin.Scene);
        public const string DropDownButton = "DropDownButton";
        public static GUIStyle DropDownButton_Game => Get(DropDownButton, EditorSkin.Game);
        public static GUIStyle DropDownButton_Inspector => Get(DropDownButton, EditorSkin.Inspector);
        public static GUIStyle DropDownButton_Scene => Get(DropDownButton, EditorSkin.Scene);
        public const string DropzoneStyle = "DropzoneStyle";
        public static GUIStyle DropzoneStyle_Game => Get(DropzoneStyle, EditorSkin.Game);
        public static GUIStyle DropzoneStyle_Inspector => Get(DropzoneStyle, EditorSkin.Inspector);
        public static GUIStyle DropzoneStyle_Scene => Get(DropzoneStyle, EditorSkin.Scene);
        public const string EditModeSingleButton = "EditModeSingleButton";
        public static GUIStyle EditModeSingleButton_Game => Get(EditModeSingleButton, EditorSkin.Game);
        public static GUIStyle EditModeSingleButton_Inspector => Get(EditModeSingleButton, EditorSkin.Inspector);
        public static GUIStyle EditModeSingleButton_Scene => Get(EditModeSingleButton, EditorSkin.Scene);
        public const string ErrorLabel = "ErrorLabel";
        public static GUIStyle ErrorLabel_Game => Get(ErrorLabel, EditorSkin.Game);
        public static GUIStyle ErrorLabel_Inspector => Get(ErrorLabel, EditorSkin.Inspector);
        public static GUIStyle ErrorLabel_Scene => Get(ErrorLabel, EditorSkin.Scene);
        public const string ExposablePopupItem = "ExposablePopupItem";
        public static GUIStyle ExposablePopupItem_Game => Get(ExposablePopupItem, EditorSkin.Game);
        public static GUIStyle ExposablePopupItem_Inspector => Get(ExposablePopupItem, EditorSkin.Inspector);
        public static GUIStyle ExposablePopupItem_Scene => Get(ExposablePopupItem, EditorSkin.Scene);
        public const string ExposablePopupMenu = "ExposablePopupMenu";
        public static GUIStyle ExposablePopupMenu_Game => Get(ExposablePopupMenu, EditorSkin.Game);
        public static GUIStyle ExposablePopupMenu_Inspector => Get(ExposablePopupMenu, EditorSkin.Inspector);
        public static GUIStyle ExposablePopupMenu_Scene => Get(ExposablePopupMenu, EditorSkin.Scene);
        public const string EyeDropperHorizontalLine = "EyeDropperHorizontalLine";
        public static GUIStyle EyeDropperHorizontalLine_Game => Get(EyeDropperHorizontalLine, EditorSkin.Game);

        public static GUIStyle EyeDropperHorizontalLine_Inspector =>
            Get(EyeDropperHorizontalLine, EditorSkin.Inspector);

        public static GUIStyle EyeDropperHorizontalLine_Scene => Get(EyeDropperHorizontalLine, EditorSkin.Scene);
        public const string EyeDropperPickedPixel = "EyeDropperPickedPixel";
        public static GUIStyle EyeDropperPickedPixel_Game => Get(EyeDropperPickedPixel, EditorSkin.Game);
        public static GUIStyle EyeDropperPickedPixel_Inspector => Get(EyeDropperPickedPixel, EditorSkin.Inspector);
        public static GUIStyle EyeDropperPickedPixel_Scene => Get(EyeDropperPickedPixel, EditorSkin.Scene);
        public const string EyeDropperVerticalLine = "EyeDropperVerticalLine";
        public static GUIStyle EyeDropperVerticalLine_Game => Get(EyeDropperVerticalLine, EditorSkin.Game);
        public static GUIStyle EyeDropperVerticalLine_Inspector => Get(EyeDropperVerticalLine, EditorSkin.Inspector);
        public static GUIStyle EyeDropperVerticalLine_Scene => Get(EyeDropperVerticalLine, EditorSkin.Scene);
        public const string FloatFieldLinkButton = "FloatFieldLinkButton";
        public static GUIStyle FloatFieldLinkButton_Game => Get(FloatFieldLinkButton, EditorSkin.Game);
        public static GUIStyle FloatFieldLinkButton_Inspector => Get(FloatFieldLinkButton, EditorSkin.Inspector);
        public static GUIStyle FloatFieldLinkButton_Scene => Get(FloatFieldLinkButton, EditorSkin.Scene);
        public const string flow_background = "flow background";
        public static GUIStyle flow_background_Game => Get(flow_background, EditorSkin.Game);
        public static GUIStyle flow_background_Inspector => Get(flow_background, EditorSkin.Inspector);
        public static GUIStyle flow_background_Scene => Get(flow_background, EditorSkin.Scene);
        public const string flow_node_0 = "flow node 0";
        public static GUIStyle flow_node_0_Game => Get(flow_node_0, EditorSkin.Game);
        public static GUIStyle flow_node_0_Inspector => Get(flow_node_0, EditorSkin.Inspector);
        public static GUIStyle flow_node_0_Scene => Get(flow_node_0, EditorSkin.Scene);
        public const string flow_node_0_on = "flow node 0 on";
        public static GUIStyle flow_node_0_on_Game => Get(flow_node_0_on, EditorSkin.Game);
        public static GUIStyle flow_node_0_on_Inspector => Get(flow_node_0_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_0_on_Scene => Get(flow_node_0_on, EditorSkin.Scene);
        public const string flow_node_1 = "flow node 1";
        public static GUIStyle flow_node_1_Game => Get(flow_node_1, EditorSkin.Game);
        public static GUIStyle flow_node_1_Inspector => Get(flow_node_1, EditorSkin.Inspector);
        public static GUIStyle flow_node_1_Scene => Get(flow_node_1, EditorSkin.Scene);
        public const string flow_node_1_on = "flow node 1 on";
        public static GUIStyle flow_node_1_on_Game => Get(flow_node_1_on, EditorSkin.Game);
        public static GUIStyle flow_node_1_on_Inspector => Get(flow_node_1_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_1_on_Scene => Get(flow_node_1_on, EditorSkin.Scene);
        public const string flow_node_2 = "flow node 2";
        public static GUIStyle flow_node_2_Game => Get(flow_node_2, EditorSkin.Game);
        public static GUIStyle flow_node_2_Inspector => Get(flow_node_2, EditorSkin.Inspector);
        public static GUIStyle flow_node_2_Scene => Get(flow_node_2, EditorSkin.Scene);
        public const string flow_node_2_on = "flow node 2 on";
        public static GUIStyle flow_node_2_on_Game => Get(flow_node_2_on, EditorSkin.Game);
        public static GUIStyle flow_node_2_on_Inspector => Get(flow_node_2_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_2_on_Scene => Get(flow_node_2_on, EditorSkin.Scene);
        public const string flow_node_3 = "flow node 3";
        public static GUIStyle flow_node_3_Game => Get(flow_node_3, EditorSkin.Game);
        public static GUIStyle flow_node_3_Inspector => Get(flow_node_3, EditorSkin.Inspector);
        public static GUIStyle flow_node_3_Scene => Get(flow_node_3, EditorSkin.Scene);
        public const string flow_node_3_on = "flow node 3 on";
        public static GUIStyle flow_node_3_on_Game => Get(flow_node_3_on, EditorSkin.Game);
        public static GUIStyle flow_node_3_on_Inspector => Get(flow_node_3_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_3_on_Scene => Get(flow_node_3_on, EditorSkin.Scene);
        public const string flow_node_4 = "flow node 4";
        public static GUIStyle flow_node_4_Game => Get(flow_node_4, EditorSkin.Game);
        public static GUIStyle flow_node_4_Inspector => Get(flow_node_4, EditorSkin.Inspector);
        public static GUIStyle flow_node_4_Scene => Get(flow_node_4, EditorSkin.Scene);
        public const string flow_node_4_on = "flow node 4 on";
        public static GUIStyle flow_node_4_on_Game => Get(flow_node_4_on, EditorSkin.Game);
        public static GUIStyle flow_node_4_on_Inspector => Get(flow_node_4_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_4_on_Scene => Get(flow_node_4_on, EditorSkin.Scene);
        public const string flow_node_5 = "flow node 5";
        public static GUIStyle flow_node_5_Game => Get(flow_node_5, EditorSkin.Game);
        public static GUIStyle flow_node_5_Inspector => Get(flow_node_5, EditorSkin.Inspector);
        public static GUIStyle flow_node_5_Scene => Get(flow_node_5, EditorSkin.Scene);
        public const string flow_node_5_on = "flow node 5 on";
        public static GUIStyle flow_node_5_on_Game => Get(flow_node_5_on, EditorSkin.Game);
        public static GUIStyle flow_node_5_on_Inspector => Get(flow_node_5_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_5_on_Scene => Get(flow_node_5_on, EditorSkin.Scene);
        public const string flow_node_6 = "flow node 6";
        public static GUIStyle flow_node_6_Game => Get(flow_node_6, EditorSkin.Game);
        public static GUIStyle flow_node_6_Inspector => Get(flow_node_6, EditorSkin.Inspector);
        public static GUIStyle flow_node_6_Scene => Get(flow_node_6, EditorSkin.Scene);
        public const string flow_node_6_on = "flow node 6 on";
        public static GUIStyle flow_node_6_on_Game => Get(flow_node_6_on, EditorSkin.Game);
        public static GUIStyle flow_node_6_on_Inspector => Get(flow_node_6_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_6_on_Scene => Get(flow_node_6_on, EditorSkin.Scene);
        public const string flow_node_base = "flow node base";
        public static GUIStyle flow_node_base_Game => Get(flow_node_base, EditorSkin.Game);
        public static GUIStyle flow_node_base_Inspector => Get(flow_node_base, EditorSkin.Inspector);
        public static GUIStyle flow_node_base_Scene => Get(flow_node_base, EditorSkin.Scene);
        public const string flow_node_hex_0 = "flow node hex 0";
        public static GUIStyle flow_node_hex_0_Game => Get(flow_node_hex_0, EditorSkin.Game);
        public static GUIStyle flow_node_hex_0_Inspector => Get(flow_node_hex_0, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_0_Scene => Get(flow_node_hex_0, EditorSkin.Scene);
        public const string flow_node_hex_0_on = "flow node hex 0 on";
        public static GUIStyle flow_node_hex_0_on_Game => Get(flow_node_hex_0_on, EditorSkin.Game);
        public static GUIStyle flow_node_hex_0_on_Inspector => Get(flow_node_hex_0_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_0_on_Scene => Get(flow_node_hex_0_on, EditorSkin.Scene);
        public const string flow_node_hex_1 = "flow node hex 1";
        public static GUIStyle flow_node_hex_1_Game => Get(flow_node_hex_1, EditorSkin.Game);
        public static GUIStyle flow_node_hex_1_Inspector => Get(flow_node_hex_1, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_1_Scene => Get(flow_node_hex_1, EditorSkin.Scene);
        public const string flow_node_hex_1_on = "flow node hex 1 on";
        public static GUIStyle flow_node_hex_1_on_Game => Get(flow_node_hex_1_on, EditorSkin.Game);
        public static GUIStyle flow_node_hex_1_on_Inspector => Get(flow_node_hex_1_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_1_on_Scene => Get(flow_node_hex_1_on, EditorSkin.Scene);
        public const string flow_node_hex_2 = "flow node hex 2";
        public static GUIStyle flow_node_hex_2_Game => Get(flow_node_hex_2, EditorSkin.Game);
        public static GUIStyle flow_node_hex_2_Inspector => Get(flow_node_hex_2, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_2_Scene => Get(flow_node_hex_2, EditorSkin.Scene);
        public const string flow_node_hex_2_on = "flow node hex 2 on";
        public static GUIStyle flow_node_hex_2_on_Game => Get(flow_node_hex_2_on, EditorSkin.Game);
        public static GUIStyle flow_node_hex_2_on_Inspector => Get(flow_node_hex_2_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_2_on_Scene => Get(flow_node_hex_2_on, EditorSkin.Scene);
        public const string flow_node_hex_3 = "flow node hex 3";
        public static GUIStyle flow_node_hex_3_Game => Get(flow_node_hex_3, EditorSkin.Game);
        public static GUIStyle flow_node_hex_3_Inspector => Get(flow_node_hex_3, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_3_Scene => Get(flow_node_hex_3, EditorSkin.Scene);
        public const string flow_node_hex_3_on = "flow node hex 3 on";
        public static GUIStyle flow_node_hex_3_on_Game => Get(flow_node_hex_3_on, EditorSkin.Game);
        public static GUIStyle flow_node_hex_3_on_Inspector => Get(flow_node_hex_3_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_3_on_Scene => Get(flow_node_hex_3_on, EditorSkin.Scene);
        public const string flow_node_hex_4 = "flow node hex 4";
        public static GUIStyle flow_node_hex_4_Game => Get(flow_node_hex_4, EditorSkin.Game);
        public static GUIStyle flow_node_hex_4_Inspector => Get(flow_node_hex_4, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_4_Scene => Get(flow_node_hex_4, EditorSkin.Scene);
        public const string flow_node_hex_4_on = "flow node hex 4 on";
        public static GUIStyle flow_node_hex_4_on_Game => Get(flow_node_hex_4_on, EditorSkin.Game);
        public static GUIStyle flow_node_hex_4_on_Inspector => Get(flow_node_hex_4_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_4_on_Scene => Get(flow_node_hex_4_on, EditorSkin.Scene);
        public const string flow_node_hex_5 = "flow node hex 5";
        public static GUIStyle flow_node_hex_5_Game => Get(flow_node_hex_5, EditorSkin.Game);
        public static GUIStyle flow_node_hex_5_Inspector => Get(flow_node_hex_5, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_5_Scene => Get(flow_node_hex_5, EditorSkin.Scene);
        public const string flow_node_hex_5_on = "flow node hex 5 on";
        public static GUIStyle flow_node_hex_5_on_Game => Get(flow_node_hex_5_on, EditorSkin.Game);
        public static GUIStyle flow_node_hex_5_on_Inspector => Get(flow_node_hex_5_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_5_on_Scene => Get(flow_node_hex_5_on, EditorSkin.Scene);
        public const string flow_node_hex_6 = "flow node hex 6";
        public static GUIStyle flow_node_hex_6_Game => Get(flow_node_hex_6, EditorSkin.Game);
        public static GUIStyle flow_node_hex_6_Inspector => Get(flow_node_hex_6, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_6_Scene => Get(flow_node_hex_6, EditorSkin.Scene);
        public const string flow_node_hex_6_on = "flow node hex 6 on";
        public static GUIStyle flow_node_hex_6_on_Game => Get(flow_node_hex_6_on, EditorSkin.Game);
        public static GUIStyle flow_node_hex_6_on_Inspector => Get(flow_node_hex_6_on, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_6_on_Scene => Get(flow_node_hex_6_on, EditorSkin.Scene);
        public const string flow_node_hex_base = "flow node hex base";
        public static GUIStyle flow_node_hex_base_Game => Get(flow_node_hex_base, EditorSkin.Game);
        public static GUIStyle flow_node_hex_base_Inspector => Get(flow_node_hex_base, EditorSkin.Inspector);
        public static GUIStyle flow_node_hex_base_Scene => Get(flow_node_hex_base, EditorSkin.Scene);
        public const string flow_node_titlebar = "flow node titlebar";
        public static GUIStyle flow_node_titlebar_Game => Get(flow_node_titlebar, EditorSkin.Game);
        public static GUIStyle flow_node_titlebar_Inspector => Get(flow_node_titlebar, EditorSkin.Inspector);
        public static GUIStyle flow_node_titlebar_Scene => Get(flow_node_titlebar, EditorSkin.Scene);
        public const string flow_target_in = "flow target in";
        public static GUIStyle flow_target_in_Game => Get(flow_target_in, EditorSkin.Game);
        public static GUIStyle flow_target_in_Inspector => Get(flow_target_in, EditorSkin.Inspector);
        public static GUIStyle flow_target_in_Scene => Get(flow_target_in, EditorSkin.Scene);
        public const string flow_triggerPin_in = "flow triggerPin in";
        public static GUIStyle flow_triggerPin_in_Game => Get(flow_triggerPin_in, EditorSkin.Game);
        public static GUIStyle flow_triggerPin_in_Inspector => Get(flow_triggerPin_in, EditorSkin.Inspector);
        public static GUIStyle flow_triggerPin_in_Scene => Get(flow_triggerPin_in, EditorSkin.Scene);
        public const string flow_triggerPin_out = "flow triggerPin out";
        public static GUIStyle flow_triggerPin_out_Game => Get(flow_triggerPin_out, EditorSkin.Game);
        public static GUIStyle flow_triggerPin_out_Inspector => Get(flow_triggerPin_out, EditorSkin.Inspector);
        public static GUIStyle flow_triggerPin_out_Scene => Get(flow_triggerPin_out, EditorSkin.Scene);
        public const string flow_varPin_in = "flow varPin in";
        public static GUIStyle flow_varPin_in_Game => Get(flow_varPin_in, EditorSkin.Game);
        public static GUIStyle flow_varPin_in_Inspector => Get(flow_varPin_in, EditorSkin.Inspector);
        public static GUIStyle flow_varPin_in_Scene => Get(flow_varPin_in, EditorSkin.Scene);
        public const string flow_varPin_out = "flow varPin out";
        public static GUIStyle flow_varPin_out_Game => Get(flow_varPin_out, EditorSkin.Game);
        public static GUIStyle flow_varPin_out_Inspector => Get(flow_varPin_out, EditorSkin.Inspector);
        public static GUIStyle flow_varPin_out_Scene => Get(flow_varPin_out, EditorSkin.Scene);
        public const string flow_varPin_tooltip = "flow varPin tooltip";
        public static GUIStyle flow_varPin_tooltip_Game => Get(flow_varPin_tooltip, EditorSkin.Game);
        public static GUIStyle flow_varPin_tooltip_Inspector => Get(flow_varPin_tooltip, EditorSkin.Inspector);
        public static GUIStyle flow_varPin_tooltip_Scene => Get(flow_varPin_tooltip, EditorSkin.Scene);
        public const string Foldout = "Foldout";
        public static GUIStyle Foldout_Game => Get(Foldout, EditorSkin.Game);
        public static GUIStyle Foldout_Inspector => Get(Foldout, EditorSkin.Inspector);
        public static GUIStyle Foldout_Scene => Get(Foldout, EditorSkin.Scene);
        public const string FoldoutHeader = "FoldoutHeader";
        public static GUIStyle FoldoutHeader_Game => Get(FoldoutHeader, EditorSkin.Game);
        public static GUIStyle FoldoutHeader_Inspector => Get(FoldoutHeader, EditorSkin.Inspector);
        public static GUIStyle FoldoutHeader_Scene => Get(FoldoutHeader, EditorSkin.Scene);
        public const string FoldoutHeaderIcon = "FoldoutHeaderIcon";
        public static GUIStyle FoldoutHeaderIcon_Game => Get(FoldoutHeaderIcon, EditorSkin.Game);
        public static GUIStyle FoldoutHeaderIcon_Inspector => Get(FoldoutHeaderIcon, EditorSkin.Inspector);
        public static GUIStyle FoldoutHeaderIcon_Scene => Get(FoldoutHeaderIcon, EditorSkin.Scene);
        public const string FoldOutPreDrop = "FoldOutPreDrop";
        public static GUIStyle FoldOutPreDrop_Game => Get(FoldOutPreDrop, EditorSkin.Game);
        public static GUIStyle FoldOutPreDrop_Inspector => Get(FoldOutPreDrop, EditorSkin.Inspector);
        public static GUIStyle FoldOutPreDrop_Scene => Get(FoldOutPreDrop, EditorSkin.Scene);
        public const string Frame = "Frame";
        public static GUIStyle Frame_Game => Get(Frame, EditorSkin.Game);
        public static GUIStyle Frame_Inspector => Get(Frame, EditorSkin.Inspector);
        public static GUIStyle Frame_Scene => Get(Frame, EditorSkin.Scene);
        public const string FrameBox = "FrameBox";
        public static GUIStyle FrameBox_Game => Get(FrameBox, EditorSkin.Game);
        public static GUIStyle FrameBox_Inspector => Get(FrameBox, EditorSkin.Inspector);
        public static GUIStyle FrameBox_Scene => Get(FrameBox, EditorSkin.Scene);
        public const string GameViewBackground = "GameViewBackground";
        public static GUIStyle GameViewBackground_Game => Get(GameViewBackground, EditorSkin.Game);
        public static GUIStyle GameViewBackground_Inspector => Get(GameViewBackground, EditorSkin.Inspector);
        public static GUIStyle GameViewBackground_Scene => Get(GameViewBackground, EditorSkin.Scene);
        public const string Grad_Down_Swatch = "Grad Down Swatch";
        public static GUIStyle Grad_Down_Swatch_Game => Get(Grad_Down_Swatch, EditorSkin.Game);
        public static GUIStyle Grad_Down_Swatch_Inspector => Get(Grad_Down_Swatch, EditorSkin.Inspector);
        public static GUIStyle Grad_Down_Swatch_Scene => Get(Grad_Down_Swatch, EditorSkin.Scene);
        public const string Grad_Down_Swatch_Overlay = "Grad Down Swatch Overlay";
        public static GUIStyle Grad_Down_Swatch_Overlay_Game => Get(Grad_Down_Swatch_Overlay, EditorSkin.Game);

        public static GUIStyle Grad_Down_Swatch_Overlay_Inspector =>
            Get(Grad_Down_Swatch_Overlay, EditorSkin.Inspector);

        public static GUIStyle Grad_Down_Swatch_Overlay_Scene => Get(Grad_Down_Swatch_Overlay, EditorSkin.Scene);
        public const string Grad_Up_Swatch = "Grad Up Swatch";
        public static GUIStyle Grad_Up_Swatch_Game => Get(Grad_Up_Swatch, EditorSkin.Game);
        public static GUIStyle Grad_Up_Swatch_Inspector => Get(Grad_Up_Swatch, EditorSkin.Inspector);
        public static GUIStyle Grad_Up_Swatch_Scene => Get(Grad_Up_Swatch, EditorSkin.Scene);
        public const string Grad_Up_Swatch_Overlay = "Grad Up Swatch Overlay";
        public static GUIStyle Grad_Up_Swatch_Overlay_Game => Get(Grad_Up_Swatch_Overlay, EditorSkin.Game);
        public static GUIStyle Grad_Up_Swatch_Overlay_Inspector => Get(Grad_Up_Swatch_Overlay, EditorSkin.Inspector);
        public static GUIStyle Grad_Up_Swatch_Overlay_Scene => Get(Grad_Up_Swatch_Overlay, EditorSkin.Scene);
        public const string grey_border = "grey_border";
        public static GUIStyle grey_border_Game => Get(grey_border, EditorSkin.Game);
        public static GUIStyle grey_border_Inspector => Get(grey_border, EditorSkin.Inspector);
        public static GUIStyle grey_border_Scene => Get(grey_border, EditorSkin.Scene);
        public const string GridList = "GridList";
        public static GUIStyle GridList_Game => Get(GridList, EditorSkin.Game);
        public static GUIStyle GridList_Inspector => Get(GridList, EditorSkin.Inspector);
        public static GUIStyle GridList_Scene => Get(GridList, EditorSkin.Scene);
        public const string GridListText = "GridListText";
        public static GUIStyle GridListText_Game => Get(GridListText, EditorSkin.Game);
        public static GUIStyle GridListText_Inspector => Get(GridListText, EditorSkin.Inspector);
        public static GUIStyle GridListText_Scene => Get(GridListText, EditorSkin.Scene);
        public const string GroupBox = "GroupBox";
        public static GUIStyle GroupBox_Game => Get(GroupBox, EditorSkin.Game);
        public static GUIStyle GroupBox_Inspector => Get(GroupBox, EditorSkin.Inspector);
        public static GUIStyle GroupBox_Scene => Get(GroupBox, EditorSkin.Scene);
        public const string GUIEditor_BreadcrumbLeft = "GUIEditor.BreadcrumbLeft";
        public static GUIStyle GUIEditor_BreadcrumbLeft_Game => Get(GUIEditor_BreadcrumbLeft, EditorSkin.Game);

        public static GUIStyle GUIEditor_BreadcrumbLeft_Inspector =>
            Get(GUIEditor_BreadcrumbLeft, EditorSkin.Inspector);

        public static GUIStyle GUIEditor_BreadcrumbLeft_Scene => Get(GUIEditor_BreadcrumbLeft, EditorSkin.Scene);
        public const string GUIEditor_BreadcrumbLeftBackground = "GUIEditor.BreadcrumbLeftBackground";

        public static GUIStyle GUIEditor_BreadcrumbLeftBackground_Game =>
            Get(GUIEditor_BreadcrumbLeftBackground, EditorSkin.Game);

        public static GUIStyle GUIEditor_BreadcrumbLeftBackground_Inspector =>
            Get(GUIEditor_BreadcrumbLeftBackground, EditorSkin.Inspector);

        public static GUIStyle GUIEditor_BreadcrumbLeftBackground_Scene =>
            Get(GUIEditor_BreadcrumbLeftBackground, EditorSkin.Scene);

        public const string GUIEditor_BreadcrumbMid = "GUIEditor.BreadcrumbMid";
        public static GUIStyle GUIEditor_BreadcrumbMid_Game => Get(GUIEditor_BreadcrumbMid, EditorSkin.Game);
        public static GUIStyle GUIEditor_BreadcrumbMid_Inspector => Get(GUIEditor_BreadcrumbMid, EditorSkin.Inspector);
        public static GUIStyle GUIEditor_BreadcrumbMid_Scene => Get(GUIEditor_BreadcrumbMid, EditorSkin.Scene);
        public const string GUIEditor_BreadcrumbMidBackground = "GUIEditor.BreadcrumbMidBackground";

        public static GUIStyle GUIEditor_BreadcrumbMidBackground_Game =>
            Get(GUIEditor_BreadcrumbMidBackground, EditorSkin.Game);

        public static GUIStyle GUIEditor_BreadcrumbMidBackground_Inspector =>
            Get(GUIEditor_BreadcrumbMidBackground, EditorSkin.Inspector);

        public static GUIStyle GUIEditor_BreadcrumbMidBackground_Scene =>
            Get(GUIEditor_BreadcrumbMidBackground, EditorSkin.Scene);

        public const string GV_Gizmo_DropDown = "GV Gizmo DropDown";
        public static GUIStyle GV_Gizmo_DropDown_Game => Get(GV_Gizmo_DropDown, EditorSkin.Game);
        public static GUIStyle GV_Gizmo_DropDown_Inspector => Get(GV_Gizmo_DropDown, EditorSkin.Inspector);
        public static GUIStyle GV_Gizmo_DropDown_Scene => Get(GV_Gizmo_DropDown, EditorSkin.Scene);
        public const string HeaderButton = "HeaderButton";
        public static GUIStyle HeaderButton_Game => Get(HeaderButton, EditorSkin.Game);
        public static GUIStyle HeaderButton_Inspector => Get(HeaderButton, EditorSkin.Inspector);
        public static GUIStyle HeaderButton_Scene => Get(HeaderButton, EditorSkin.Scene);
        public const string HeaderLabel = "HeaderLabel";
        public static GUIStyle HeaderLabel_Game => Get(HeaderLabel, EditorSkin.Game);
        public static GUIStyle HeaderLabel_Inspector => Get(HeaderLabel, EditorSkin.Inspector);
        public static GUIStyle HeaderLabel_Scene => Get(HeaderLabel, EditorSkin.Scene);
        public const string HelpBox = "HelpBox";
        public static GUIStyle HelpBox_Game => Get(HelpBox, EditorSkin.Game);
        public static GUIStyle HelpBox_Inspector => Get(HelpBox, EditorSkin.Inspector);
        public static GUIStyle HelpBox_Scene => Get(HelpBox, EditorSkin.Scene);
        public const string Hi_Label = "Hi Label";
        public static GUIStyle Hi_Label_Game => Get(Hi_Label, EditorSkin.Game);
        public static GUIStyle Hi_Label_Inspector => Get(Hi_Label, EditorSkin.Inspector);
        public static GUIStyle Hi_Label_Scene => Get(Hi_Label, EditorSkin.Scene);
        public const string HorizontalMinMaxScrollbarThumb = "HorizontalMinMaxScrollbarThumb";

        public static GUIStyle HorizontalMinMaxScrollbarThumb_Game =>
            Get(HorizontalMinMaxScrollbarThumb, EditorSkin.Game);

        public static GUIStyle HorizontalMinMaxScrollbarThumb_Inspector =>
            Get(HorizontalMinMaxScrollbarThumb, EditorSkin.Inspector);

        public static GUIStyle HorizontalMinMaxScrollbarThumb_Scene =>
            Get(HorizontalMinMaxScrollbarThumb, EditorSkin.Scene);

        public const string HorizontalSliderThumbExtent = "HorizontalSliderThumbExtent";
        public static GUIStyle HorizontalSliderThumbExtent_Game => Get(HorizontalSliderThumbExtent, EditorSkin.Game);

        public static GUIStyle HorizontalSliderThumbExtent_Inspector =>
            Get(HorizontalSliderThumbExtent, EditorSkin.Inspector);

        public static GUIStyle HorizontalSliderThumbExtent_Scene => Get(HorizontalSliderThumbExtent, EditorSkin.Scene);
        public const string hostview = "hostview";
        public static GUIStyle hostview_Game => Get(hostview, EditorSkin.Game);
        public static GUIStyle hostview_Inspector => Get(hostview, EditorSkin.Inspector);
        public static GUIStyle hostview_Scene => Get(hostview, EditorSkin.Scene);
        public const string IconButton = "IconButton";
        public static GUIStyle IconButton_Game => Get(IconButton, EditorSkin.Game);
        public static GUIStyle IconButton_Inspector => Get(IconButton, EditorSkin.Inspector);
        public static GUIStyle IconButton_Scene => Get(IconButton, EditorSkin.Scene);
        public const string IN_BigTitle = "IN BigTitle";
        public static GUIStyle IN_BigTitle_Game => Get(IN_BigTitle, EditorSkin.Game);
        public static GUIStyle IN_BigTitle_Inspector => Get(IN_BigTitle, EditorSkin.Inspector);
        public static GUIStyle IN_BigTitle_Scene => Get(IN_BigTitle, EditorSkin.Scene);
        public const string IN_BigTitle_Inner = "IN BigTitle Inner";
        public static GUIStyle IN_BigTitle_Inner_Game => Get(IN_BigTitle_Inner, EditorSkin.Game);
        public static GUIStyle IN_BigTitle_Inner_Inspector => Get(IN_BigTitle_Inner, EditorSkin.Inspector);
        public static GUIStyle IN_BigTitle_Inner_Scene => Get(IN_BigTitle_Inner, EditorSkin.Scene);
        public const string IN_BigTitle_Post = "IN BigTitle Post";
        public static GUIStyle IN_BigTitle_Post_Game => Get(IN_BigTitle_Post, EditorSkin.Game);
        public static GUIStyle IN_BigTitle_Post_Inspector => Get(IN_BigTitle_Post, EditorSkin.Inspector);
        public static GUIStyle IN_BigTitle_Post_Scene => Get(IN_BigTitle_Post, EditorSkin.Scene);
        public const string IN_CenteredLabel = "IN CenteredLabel";
        public static GUIStyle IN_CenteredLabel_Game => Get(IN_CenteredLabel, EditorSkin.Game);
        public static GUIStyle IN_CenteredLabel_Inspector => Get(IN_CenteredLabel, EditorSkin.Inspector);
        public static GUIStyle IN_CenteredLabel_Scene => Get(IN_CenteredLabel, EditorSkin.Scene);
        public const string IN_DropDown = "IN DropDown";
        public static GUIStyle IN_DropDown_Game => Get(IN_DropDown, EditorSkin.Game);
        public static GUIStyle IN_DropDown_Inspector => Get(IN_DropDown, EditorSkin.Inspector);
        public static GUIStyle IN_DropDown_Scene => Get(IN_DropDown, EditorSkin.Scene);
        public const string IN_EditColliderButton = "IN EditColliderButton";
        public static GUIStyle IN_EditColliderButton_Game => Get(IN_EditColliderButton, EditorSkin.Game);
        public static GUIStyle IN_EditColliderButton_Inspector => Get(IN_EditColliderButton, EditorSkin.Inspector);
        public static GUIStyle IN_EditColliderButton_Scene => Get(IN_EditColliderButton, EditorSkin.Scene);
        public const string IN_Foldout = "IN Foldout";
        public static GUIStyle IN_Foldout_Game => Get(IN_Foldout, EditorSkin.Game);
        public static GUIStyle IN_Foldout_Inspector => Get(IN_Foldout, EditorSkin.Inspector);
        public static GUIStyle IN_Foldout_Scene => Get(IN_Foldout, EditorSkin.Scene);
        public const string IN_Footer = "IN Footer";
        public static GUIStyle IN_Footer_Game => Get(IN_Footer, EditorSkin.Game);
        public static GUIStyle IN_Footer_Inspector => Get(IN_Footer, EditorSkin.Inspector);
        public static GUIStyle IN_Footer_Scene => Get(IN_Footer, EditorSkin.Scene);
        public const string IN_Label = "IN Label";
        public static GUIStyle IN_Label_Game => Get(IN_Label, EditorSkin.Game);
        public static GUIStyle IN_Label_Inspector => Get(IN_Label, EditorSkin.Inspector);
        public static GUIStyle IN_Label_Scene => Get(IN_Label, EditorSkin.Scene);
        public const string IN_LockButton = "IN LockButton";
        public static GUIStyle IN_LockButton_Game => Get(IN_LockButton, EditorSkin.Game);
        public static GUIStyle IN_LockButton_Inspector => Get(IN_LockButton, EditorSkin.Inspector);
        public static GUIStyle IN_LockButton_Scene => Get(IN_LockButton, EditorSkin.Scene);
        public const string IN_MinMaxStateDropDown = "IN MinMaxStateDropDown";
        public static GUIStyle IN_MinMaxStateDropDown_Game => Get(IN_MinMaxStateDropDown, EditorSkin.Game);
        public static GUIStyle IN_MinMaxStateDropDown_Inspector => Get(IN_MinMaxStateDropDown, EditorSkin.Inspector);
        public static GUIStyle IN_MinMaxStateDropDown_Scene => Get(IN_MinMaxStateDropDown, EditorSkin.Scene);
        public const string IN_ObjectField = "IN ObjectField";
        public static GUIStyle IN_ObjectField_Game => Get(IN_ObjectField, EditorSkin.Game);
        public static GUIStyle IN_ObjectField_Inspector => Get(IN_ObjectField, EditorSkin.Inspector);
        public static GUIStyle IN_ObjectField_Scene => Get(IN_ObjectField, EditorSkin.Scene);
        public const string IN_TextField = "IN TextField";
        public static GUIStyle IN_TextField_Game => Get(IN_TextField, EditorSkin.Game);
        public static GUIStyle IN_TextField_Inspector => Get(IN_TextField, EditorSkin.Inspector);
        public static GUIStyle IN_TextField_Scene => Get(IN_TextField, EditorSkin.Scene);
        public const string IN_ThumbnailSelection = "IN ThumbnailSelection";
        public static GUIStyle IN_ThumbnailSelection_Game => Get(IN_ThumbnailSelection, EditorSkin.Game);
        public static GUIStyle IN_ThumbnailSelection_Inspector => Get(IN_ThumbnailSelection, EditorSkin.Inspector);
        public static GUIStyle IN_ThumbnailSelection_Scene => Get(IN_ThumbnailSelection, EditorSkin.Scene);
        public const string IN_ThumbnailShadow = "IN ThumbnailShadow";
        public static GUIStyle IN_ThumbnailShadow_Game => Get(IN_ThumbnailShadow, EditorSkin.Game);
        public static GUIStyle IN_ThumbnailShadow_Inspector => Get(IN_ThumbnailShadow, EditorSkin.Inspector);
        public static GUIStyle IN_ThumbnailShadow_Scene => Get(IN_ThumbnailShadow, EditorSkin.Scene);
        public const string IN_Title = "IN Title";
        public static GUIStyle IN_Title_Game => Get(IN_Title, EditorSkin.Game);
        public static GUIStyle IN_Title_Inspector => Get(IN_Title, EditorSkin.Inspector);
        public static GUIStyle IN_Title_Scene => Get(IN_Title, EditorSkin.Scene);
        public const string IN_Title_Flat = "IN Title Flat";
        public static GUIStyle IN_Title_Flat_Game => Get(IN_Title_Flat, EditorSkin.Game);
        public static GUIStyle IN_Title_Flat_Inspector => Get(IN_Title_Flat, EditorSkin.Inspector);
        public static GUIStyle IN_Title_Flat_Scene => Get(IN_Title_Flat, EditorSkin.Scene);
        public const string IN_TitleText = "IN TitleText";
        public static GUIStyle IN_TitleText_Game => Get(IN_TitleText, EditorSkin.Game);
        public static GUIStyle IN_TitleText_Inspector => Get(IN_TitleText, EditorSkin.Inspector);
        public static GUIStyle IN_TitleText_Scene => Get(IN_TitleText, EditorSkin.Scene);
        public const string IN_TypeSelection = "IN TypeSelection";
        public static GUIStyle IN_TypeSelection_Game => Get(IN_TypeSelection, EditorSkin.Game);
        public static GUIStyle IN_TypeSelection_Inspector => Get(IN_TypeSelection, EditorSkin.Inspector);
        public static GUIStyle IN_TypeSelection_Scene => Get(IN_TypeSelection, EditorSkin.Scene);
        public const string InnerShadowBg = "InnerShadowBg";
        public static GUIStyle InnerShadowBg_Game => Get(InnerShadowBg, EditorSkin.Game);
        public static GUIStyle InnerShadowBg_Inspector => Get(InnerShadowBg, EditorSkin.Inspector);
        public static GUIStyle InnerShadowBg_Scene => Get(InnerShadowBg, EditorSkin.Scene);
        public const string InsertionMarker = "InsertionMarker";
        public static GUIStyle InsertionMarker_Game => Get(InsertionMarker, EditorSkin.Game);
        public static GUIStyle InsertionMarker_Inspector => Get(InsertionMarker, EditorSkin.Inspector);
        public static GUIStyle InsertionMarker_Scene => Get(InsertionMarker, EditorSkin.Scene);
        public const string InvisibleButton = "InvisibleButton";
        public static GUIStyle InvisibleButton_Game => Get(InvisibleButton, EditorSkin.Game);
        public static GUIStyle InvisibleButton_Inspector => Get(InvisibleButton, EditorSkin.Inspector);
        public static GUIStyle InvisibleButton_Scene => Get(InvisibleButton, EditorSkin.Scene);
        public const string LargeBoldLabel = "LargeBoldLabel";
        public static GUIStyle LargeBoldLabel_Game => Get(LargeBoldLabel, EditorSkin.Game);
        public static GUIStyle LargeBoldLabel_Inspector => Get(LargeBoldLabel, EditorSkin.Inspector);
        public static GUIStyle LargeBoldLabel_Scene => Get(LargeBoldLabel, EditorSkin.Scene);
        public const string LargeButton = "LargeButton";
        public static GUIStyle LargeButton_Game => Get(LargeButton, EditorSkin.Game);
        public static GUIStyle LargeButton_Inspector => Get(LargeButton, EditorSkin.Inspector);
        public static GUIStyle LargeButton_Scene => Get(LargeButton, EditorSkin.Scene);
        public const string LargeButtonLeft = "LargeButtonLeft";
        public static GUIStyle LargeButtonLeft_Game => Get(LargeButtonLeft, EditorSkin.Game);
        public static GUIStyle LargeButtonLeft_Inspector => Get(LargeButtonLeft, EditorSkin.Inspector);
        public static GUIStyle LargeButtonLeft_Scene => Get(LargeButtonLeft, EditorSkin.Scene);
        public const string LargeButtonMid = "LargeButtonMid";
        public static GUIStyle LargeButtonMid_Game => Get(LargeButtonMid, EditorSkin.Game);
        public static GUIStyle LargeButtonMid_Inspector => Get(LargeButtonMid, EditorSkin.Inspector);
        public static GUIStyle LargeButtonMid_Scene => Get(LargeButtonMid, EditorSkin.Scene);
        public const string LargeButtonRight = "LargeButtonRight";
        public static GUIStyle LargeButtonRight_Game => Get(LargeButtonRight, EditorSkin.Game);
        public static GUIStyle LargeButtonRight_Inspector => Get(LargeButtonRight, EditorSkin.Inspector);
        public static GUIStyle LargeButtonRight_Scene => Get(LargeButtonRight, EditorSkin.Scene);
        public const string LargeLabel = "LargeLabel";
        public static GUIStyle LargeLabel_Game => Get(LargeLabel, EditorSkin.Game);
        public static GUIStyle LargeLabel_Inspector => Get(LargeLabel, EditorSkin.Inspector);
        public static GUIStyle LargeLabel_Scene => Get(LargeLabel, EditorSkin.Scene);
        public const string LightmapEditorSelectedHighlight = "LightmapEditorSelectedHighlight";

        public static GUIStyle LightmapEditorSelectedHighlight_Game =>
            Get(LightmapEditorSelectedHighlight, EditorSkin.Game);

        public static GUIStyle LightmapEditorSelectedHighlight_Inspector =>
            Get(LightmapEditorSelectedHighlight, EditorSkin.Inspector);

        public static GUIStyle LightmapEditorSelectedHighlight_Scene =>
            Get(LightmapEditorSelectedHighlight, EditorSkin.Scene);

        public const string LinkLabel = "LinkLabel";
        public static GUIStyle LinkLabel_Game => Get(LinkLabel, EditorSkin.Game);
        public static GUIStyle LinkLabel_Inspector => Get(LinkLabel, EditorSkin.Inspector);
        public static GUIStyle LinkLabel_Scene => Get(LinkLabel, EditorSkin.Scene);
        public const string LODBlackBox = "LODBlackBox";
        public static GUIStyle LODBlackBox_Game => Get(LODBlackBox, EditorSkin.Game);
        public static GUIStyle LODBlackBox_Inspector => Get(LODBlackBox, EditorSkin.Inspector);
        public static GUIStyle LODBlackBox_Scene => Get(LODBlackBox, EditorSkin.Scene);
        public const string LODCameraLine = "LODCameraLine";
        public static GUIStyle LODCameraLine_Game => Get(LODCameraLine, EditorSkin.Game);
        public static GUIStyle LODCameraLine_Inspector => Get(LODCameraLine, EditorSkin.Inspector);
        public static GUIStyle LODCameraLine_Scene => Get(LODCameraLine, EditorSkin.Scene);
        public const string LODLevelNotifyText = "LODLevelNotifyText";
        public static GUIStyle LODLevelNotifyText_Game => Get(LODLevelNotifyText, EditorSkin.Game);
        public static GUIStyle LODLevelNotifyText_Inspector => Get(LODLevelNotifyText, EditorSkin.Inspector);
        public static GUIStyle LODLevelNotifyText_Scene => Get(LODLevelNotifyText, EditorSkin.Scene);
        public const string LODRendererAddButton = "LODRendererAddButton";
        public static GUIStyle LODRendererAddButton_Game => Get(LODRendererAddButton, EditorSkin.Game);
        public static GUIStyle LODRendererAddButton_Inspector => Get(LODRendererAddButton, EditorSkin.Inspector);
        public static GUIStyle LODRendererAddButton_Scene => Get(LODRendererAddButton, EditorSkin.Scene);
        public const string LODRendererButton = "LODRendererButton";
        public static GUIStyle LODRendererButton_Game => Get(LODRendererButton, EditorSkin.Game);
        public static GUIStyle LODRendererButton_Inspector => Get(LODRendererButton, EditorSkin.Inspector);
        public static GUIStyle LODRendererButton_Scene => Get(LODRendererButton, EditorSkin.Scene);
        public const string LODRendererRemove = "LODRendererRemove";
        public static GUIStyle LODRendererRemove_Game => Get(LODRendererRemove, EditorSkin.Game);
        public static GUIStyle LODRendererRemove_Inspector => Get(LODRendererRemove, EditorSkin.Inspector);
        public static GUIStyle LODRendererRemove_Scene => Get(LODRendererRemove, EditorSkin.Scene);
        public const string LODRenderersText = "LODRenderersText";
        public static GUIStyle LODRenderersText_Game => Get(LODRenderersText, EditorSkin.Game);
        public static GUIStyle LODRenderersText_Inspector => Get(LODRenderersText, EditorSkin.Inspector);
        public static GUIStyle LODRenderersText_Scene => Get(LODRenderersText, EditorSkin.Scene);
        public const string LODSceneText = "LODSceneText";
        public static GUIStyle LODSceneText_Game => Get(LODSceneText, EditorSkin.Game);
        public static GUIStyle LODSceneText_Inspector => Get(LODSceneText, EditorSkin.Inspector);
        public static GUIStyle LODSceneText_Scene => Get(LODSceneText, EditorSkin.Scene);
        public const string LODSliderBG = "LODSliderBG";
        public static GUIStyle LODSliderBG_Game => Get(LODSliderBG, EditorSkin.Game);
        public static GUIStyle LODSliderBG_Inspector => Get(LODSliderBG, EditorSkin.Inspector);
        public static GUIStyle LODSliderBG_Scene => Get(LODSliderBG, EditorSkin.Scene);
        public const string LODSliderRange = "LODSliderRange";
        public static GUIStyle LODSliderRange_Game => Get(LODSliderRange, EditorSkin.Game);
        public static GUIStyle LODSliderRange_Inspector => Get(LODSliderRange, EditorSkin.Inspector);
        public static GUIStyle LODSliderRange_Scene => Get(LODSliderRange, EditorSkin.Scene);
        public const string LODSliderRangeSelected = "LODSliderRangeSelected";
        public static GUIStyle LODSliderRangeSelected_Game => Get(LODSliderRangeSelected, EditorSkin.Game);
        public static GUIStyle LODSliderRangeSelected_Inspector => Get(LODSliderRangeSelected, EditorSkin.Inspector);
        public static GUIStyle LODSliderRangeSelected_Scene => Get(LODSliderRangeSelected, EditorSkin.Scene);
        public const string LODSliderText = "LODSliderText";
        public static GUIStyle LODSliderText_Game => Get(LODSliderText, EditorSkin.Game);
        public static GUIStyle LODSliderText_Inspector => Get(LODSliderText, EditorSkin.Inspector);
        public static GUIStyle LODSliderText_Scene => Get(LODSliderText, EditorSkin.Scene);
        public const string LODSliderTextSelected = "LODSliderTextSelected";
        public static GUIStyle LODSliderTextSelected_Game => Get(LODSliderTextSelected, EditorSkin.Game);
        public static GUIStyle LODSliderTextSelected_Inspector => Get(LODSliderTextSelected, EditorSkin.Inspector);
        public static GUIStyle LODSliderTextSelected_Scene => Get(LODSliderTextSelected, EditorSkin.Scene);
        public const string MeBlendBackground = "MeBlendBackground";
        public static GUIStyle MeBlendBackground_Game => Get(MeBlendBackground, EditorSkin.Game);
        public static GUIStyle MeBlendBackground_Inspector => Get(MeBlendBackground, EditorSkin.Inspector);
        public static GUIStyle MeBlendBackground_Scene => Get(MeBlendBackground, EditorSkin.Scene);
        public const string MeBlendPosition = "MeBlendPosition";
        public static GUIStyle MeBlendPosition_Game => Get(MeBlendPosition, EditorSkin.Game);
        public static GUIStyle MeBlendPosition_Inspector => Get(MeBlendPosition, EditorSkin.Inspector);
        public static GUIStyle MeBlendPosition_Scene => Get(MeBlendPosition, EditorSkin.Scene);
        public const string MeBlendTriangleLeft = "MeBlendTriangleLeft";
        public static GUIStyle MeBlendTriangleLeft_Game => Get(MeBlendTriangleLeft, EditorSkin.Game);
        public static GUIStyle MeBlendTriangleLeft_Inspector => Get(MeBlendTriangleLeft, EditorSkin.Inspector);
        public static GUIStyle MeBlendTriangleLeft_Scene => Get(MeBlendTriangleLeft, EditorSkin.Scene);
        public const string MeBlendTriangleRight = "MeBlendTriangleRight";
        public static GUIStyle MeBlendTriangleRight_Game => Get(MeBlendTriangleRight, EditorSkin.Game);
        public static GUIStyle MeBlendTriangleRight_Inspector => Get(MeBlendTriangleRight, EditorSkin.Inspector);
        public static GUIStyle MeBlendTriangleRight_Scene => Get(MeBlendTriangleRight, EditorSkin.Scene);
        public const string MeLivePlayBackground = "MeLivePlayBackground";
        public static GUIStyle MeLivePlayBackground_Game => Get(MeLivePlayBackground, EditorSkin.Game);
        public static GUIStyle MeLivePlayBackground_Inspector => Get(MeLivePlayBackground, EditorSkin.Inspector);
        public static GUIStyle MeLivePlayBackground_Scene => Get(MeLivePlayBackground, EditorSkin.Scene);
        public const string MeLivePlayBar = "MeLivePlayBar";
        public static GUIStyle MeLivePlayBar_Game => Get(MeLivePlayBar, EditorSkin.Game);
        public static GUIStyle MeLivePlayBar_Inspector => Get(MeLivePlayBar, EditorSkin.Inspector);
        public static GUIStyle MeLivePlayBar_Scene => Get(MeLivePlayBar, EditorSkin.Scene);
        public const string MenuItem = "MenuItem";
        public static GUIStyle MenuItem_Game => Get(MenuItem, EditorSkin.Game);
        public static GUIStyle MenuItem_Inspector => Get(MenuItem, EditorSkin.Inspector);
        public static GUIStyle MenuItem_Scene => Get(MenuItem, EditorSkin.Scene);
        public const string MenuItemMixed = "MenuItemMixed";
        public static GUIStyle MenuItemMixed_Game => Get(MenuItemMixed, EditorSkin.Game);
        public static GUIStyle MenuItemMixed_Inspector => Get(MenuItemMixed, EditorSkin.Inspector);
        public static GUIStyle MenuItemMixed_Scene => Get(MenuItemMixed, EditorSkin.Scene);
        public const string MenuToggleItem = "MenuToggleItem";
        public static GUIStyle MenuToggleItem_Game => Get(MenuToggleItem, EditorSkin.Game);
        public static GUIStyle MenuToggleItem_Inspector => Get(MenuToggleItem, EditorSkin.Inspector);
        public static GUIStyle MenuToggleItem_Scene => Get(MenuToggleItem, EditorSkin.Scene);
        public const string MeTimeBlockLeft = "MeTimeBlockLeft";
        public static GUIStyle MeTimeBlockLeft_Game => Get(MeTimeBlockLeft, EditorSkin.Game);
        public static GUIStyle MeTimeBlockLeft_Inspector => Get(MeTimeBlockLeft, EditorSkin.Inspector);
        public static GUIStyle MeTimeBlockLeft_Scene => Get(MeTimeBlockLeft, EditorSkin.Scene);
        public const string MeTimeBlockRight = "MeTimeBlockRight";
        public static GUIStyle MeTimeBlockRight_Game => Get(MeTimeBlockRight, EditorSkin.Game);
        public static GUIStyle MeTimeBlockRight_Inspector => Get(MeTimeBlockRight, EditorSkin.Inspector);
        public static GUIStyle MeTimeBlockRight_Scene => Get(MeTimeBlockRight, EditorSkin.Scene);
        public const string MeTimeLabel = "MeTimeLabel";
        public static GUIStyle MeTimeLabel_Game => Get(MeTimeLabel, EditorSkin.Game);
        public static GUIStyle MeTimeLabel_Inspector => Get(MeTimeLabel, EditorSkin.Inspector);
        public static GUIStyle MeTimeLabel_Scene => Get(MeTimeLabel, EditorSkin.Scene);
        public const string MeTransitionBack = "MeTransitionBack";
        public static GUIStyle MeTransitionBack_Game => Get(MeTransitionBack, EditorSkin.Game);
        public static GUIStyle MeTransitionBack_Inspector => Get(MeTransitionBack, EditorSkin.Inspector);
        public static GUIStyle MeTransitionBack_Scene => Get(MeTransitionBack, EditorSkin.Scene);
        public const string MeTransitionBlock = "MeTransitionBlock";
        public static GUIStyle MeTransitionBlock_Game => Get(MeTransitionBlock, EditorSkin.Game);
        public static GUIStyle MeTransitionBlock_Inspector => Get(MeTransitionBlock, EditorSkin.Inspector);
        public static GUIStyle MeTransitionBlock_Scene => Get(MeTransitionBlock, EditorSkin.Scene);
        public const string MeTransitionHandleLeft = "MeTransitionHandleLeft";
        public static GUIStyle MeTransitionHandleLeft_Game => Get(MeTransitionHandleLeft, EditorSkin.Game);
        public static GUIStyle MeTransitionHandleLeft_Inspector => Get(MeTransitionHandleLeft, EditorSkin.Inspector);
        public static GUIStyle MeTransitionHandleLeft_Scene => Get(MeTransitionHandleLeft, EditorSkin.Scene);
        public const string MeTransitionHandleLeftPrev = "MeTransitionHandleLeftPrev";
        public static GUIStyle MeTransitionHandleLeftPrev_Game => Get(MeTransitionHandleLeftPrev, EditorSkin.Game);

        public static GUIStyle MeTransitionHandleLeftPrev_Inspector =>
            Get(MeTransitionHandleLeftPrev, EditorSkin.Inspector);

        public static GUIStyle MeTransitionHandleLeftPrev_Scene => Get(MeTransitionHandleLeftPrev, EditorSkin.Scene);
        public const string MeTransitionHandleRight = "MeTransitionHandleRight";
        public static GUIStyle MeTransitionHandleRight_Game => Get(MeTransitionHandleRight, EditorSkin.Game);
        public static GUIStyle MeTransitionHandleRight_Inspector => Get(MeTransitionHandleRight, EditorSkin.Inspector);
        public static GUIStyle MeTransitionHandleRight_Scene => Get(MeTransitionHandleRight, EditorSkin.Scene);
        public const string MeTransitionHead = "MeTransitionHead";
        public static GUIStyle MeTransitionHead_Game => Get(MeTransitionHead, EditorSkin.Game);
        public static GUIStyle MeTransitionHead_Inspector => Get(MeTransitionHead, EditorSkin.Inspector);
        public static GUIStyle MeTransitionHead_Scene => Get(MeTransitionHead, EditorSkin.Scene);
        public const string MeTransitionSelect = "MeTransitionSelect";
        public static GUIStyle MeTransitionSelect_Game => Get(MeTransitionSelect, EditorSkin.Game);
        public static GUIStyle MeTransitionSelect_Inspector => Get(MeTransitionSelect, EditorSkin.Inspector);
        public static GUIStyle MeTransitionSelect_Scene => Get(MeTransitionSelect, EditorSkin.Scene);
        public const string MeTransitionSelectHead = "MeTransitionSelectHead";
        public static GUIStyle MeTransitionSelectHead_Game => Get(MeTransitionSelectHead, EditorSkin.Game);
        public static GUIStyle MeTransitionSelectHead_Inspector => Get(MeTransitionSelectHead, EditorSkin.Inspector);
        public static GUIStyle MeTransitionSelectHead_Scene => Get(MeTransitionSelectHead, EditorSkin.Scene);
        public const string MeTransOff2On = "MeTransOff2On";
        public static GUIStyle MeTransOff2On_Game => Get(MeTransOff2On, EditorSkin.Game);
        public static GUIStyle MeTransOff2On_Inspector => Get(MeTransOff2On, EditorSkin.Inspector);
        public static GUIStyle MeTransOff2On_Scene => Get(MeTransOff2On, EditorSkin.Scene);
        public const string MeTransOffLeft = "MeTransOffLeft";
        public static GUIStyle MeTransOffLeft_Game => Get(MeTransOffLeft, EditorSkin.Game);
        public static GUIStyle MeTransOffLeft_Inspector => Get(MeTransOffLeft, EditorSkin.Inspector);
        public static GUIStyle MeTransOffLeft_Scene => Get(MeTransOffLeft, EditorSkin.Scene);
        public const string MeTransOffRight = "MeTransOffRight";
        public static GUIStyle MeTransOffRight_Game => Get(MeTransOffRight, EditorSkin.Game);
        public static GUIStyle MeTransOffRight_Inspector => Get(MeTransOffRight, EditorSkin.Inspector);
        public static GUIStyle MeTransOffRight_Scene => Get(MeTransOffRight, EditorSkin.Scene);
        public const string MeTransOn2Off = "MeTransOn2Off";
        public static GUIStyle MeTransOn2Off_Game => Get(MeTransOn2Off, EditorSkin.Game);
        public static GUIStyle MeTransOn2Off_Inspector => Get(MeTransOn2Off, EditorSkin.Inspector);
        public static GUIStyle MeTransOn2Off_Scene => Get(MeTransOn2Off, EditorSkin.Scene);
        public const string MeTransOnLeft = "MeTransOnLeft";
        public static GUIStyle MeTransOnLeft_Game => Get(MeTransOnLeft, EditorSkin.Game);
        public static GUIStyle MeTransOnLeft_Inspector => Get(MeTransOnLeft, EditorSkin.Inspector);
        public static GUIStyle MeTransOnLeft_Scene => Get(MeTransOnLeft, EditorSkin.Scene);
        public const string MeTransOnRight = "MeTransOnRight";
        public static GUIStyle MeTransOnRight_Game => Get(MeTransOnRight, EditorSkin.Game);
        public static GUIStyle MeTransOnRight_Inspector => Get(MeTransOnRight, EditorSkin.Inspector);
        public static GUIStyle MeTransOnRight_Scene => Get(MeTransOnRight, EditorSkin.Scene);
        public const string MeTransPlayhead = "MeTransPlayhead";
        public static GUIStyle MeTransPlayhead_Game => Get(MeTransPlayhead, EditorSkin.Game);
        public static GUIStyle MeTransPlayhead_Inspector => Get(MeTransPlayhead, EditorSkin.Inspector);
        public static GUIStyle MeTransPlayhead_Scene => Get(MeTransPlayhead, EditorSkin.Scene);
        public const string MiniBoldLabel = "MiniBoldLabel";
        public static GUIStyle MiniBoldLabel_Game => Get(MiniBoldLabel, EditorSkin.Game);
        public static GUIStyle MiniBoldLabel_Inspector => Get(MiniBoldLabel, EditorSkin.Inspector);
        public static GUIStyle MiniBoldLabel_Scene => Get(MiniBoldLabel, EditorSkin.Scene);
        public const string minibutton = "minibutton";
        public static GUIStyle minibutton_Game => Get(minibutton, EditorSkin.Game);
        public static GUIStyle minibutton_Inspector => Get(minibutton, EditorSkin.Inspector);
        public static GUIStyle minibutton_Scene => Get(minibutton, EditorSkin.Scene);
        public const string minibuttonleft = "minibuttonleft";
        public static GUIStyle minibuttonleft_Game => Get(minibuttonleft, EditorSkin.Game);
        public static GUIStyle minibuttonleft_Inspector => Get(minibuttonleft, EditorSkin.Inspector);
        public static GUIStyle minibuttonleft_Scene => Get(minibuttonleft, EditorSkin.Scene);
        public const string minibuttonmid = "minibuttonmid";
        public static GUIStyle minibuttonmid_Game => Get(minibuttonmid, EditorSkin.Game);
        public static GUIStyle minibuttonmid_Inspector => Get(minibuttonmid, EditorSkin.Inspector);
        public static GUIStyle minibuttonmid_Scene => Get(minibuttonmid, EditorSkin.Scene);
        public const string minibuttonright = "minibuttonright";
        public static GUIStyle minibuttonright_Game => Get(minibuttonright, EditorSkin.Game);
        public static GUIStyle minibuttonright_Inspector => Get(minibuttonright, EditorSkin.Inspector);
        public static GUIStyle minibuttonright_Scene => Get(minibuttonright, EditorSkin.Scene);
        public const string MiniLabel = "MiniLabel";
        public static GUIStyle MiniLabel_Game => Get(MiniLabel, EditorSkin.Game);
        public static GUIStyle MiniLabel_Inspector => Get(MiniLabel, EditorSkin.Inspector);
        public static GUIStyle MiniLabel_Scene => Get(MiniLabel, EditorSkin.Scene);
        public const string MiniMinMaxSliderHorizontal = "MiniMinMaxSliderHorizontal";
        public static GUIStyle MiniMinMaxSliderHorizontal_Game => Get(MiniMinMaxSliderHorizontal, EditorSkin.Game);

        public static GUIStyle MiniMinMaxSliderHorizontal_Inspector =>
            Get(MiniMinMaxSliderHorizontal, EditorSkin.Inspector);

        public static GUIStyle MiniMinMaxSliderHorizontal_Scene => Get(MiniMinMaxSliderHorizontal, EditorSkin.Scene);
        public const string MiniMinMaxSliderVertical = "MiniMinMaxSliderVertical";
        public static GUIStyle MiniMinMaxSliderVertical_Game => Get(MiniMinMaxSliderVertical, EditorSkin.Game);

        public static GUIStyle MiniMinMaxSliderVertical_Inspector =>
            Get(MiniMinMaxSliderVertical, EditorSkin.Inspector);

        public static GUIStyle MiniMinMaxSliderVertical_Scene => Get(MiniMinMaxSliderVertical, EditorSkin.Scene);
        public const string MiniPopup = "MiniPopup";
        public static GUIStyle MiniPopup_Game => Get(MiniPopup, EditorSkin.Game);
        public static GUIStyle MiniPopup_Inspector => Get(MiniPopup, EditorSkin.Inspector);
        public static GUIStyle MiniPopup_Scene => Get(MiniPopup, EditorSkin.Scene);
        public const string MiniPullDown = "MiniPullDown";
        public static GUIStyle MiniPullDown_Game => Get(MiniPullDown, EditorSkin.Game);
        public static GUIStyle MiniPullDown_Inspector => Get(MiniPullDown, EditorSkin.Inspector);
        public static GUIStyle MiniPullDown_Scene => Get(MiniPullDown, EditorSkin.Scene);
        public const string MiniSliderHorizontal = "MiniSliderHorizontal";
        public static GUIStyle MiniSliderHorizontal_Game => Get(MiniSliderHorizontal, EditorSkin.Game);
        public static GUIStyle MiniSliderHorizontal_Inspector => Get(MiniSliderHorizontal, EditorSkin.Inspector);
        public static GUIStyle MiniSliderHorizontal_Scene => Get(MiniSliderHorizontal, EditorSkin.Scene);
        public const string MiniSliderVertical = "MiniSliderVertical";
        public static GUIStyle MiniSliderVertical_Game => Get(MiniSliderVertical, EditorSkin.Game);
        public static GUIStyle MiniSliderVertical_Inspector => Get(MiniSliderVertical, EditorSkin.Inspector);
        public static GUIStyle MiniSliderVertical_Scene => Get(MiniSliderVertical, EditorSkin.Scene);
        public const string MiniTextField = "MiniTextField";
        public static GUIStyle MiniTextField_Game => Get(MiniTextField, EditorSkin.Game);
        public static GUIStyle MiniTextField_Inspector => Get(MiniTextField, EditorSkin.Inspector);
        public static GUIStyle MiniTextField_Scene => Get(MiniTextField, EditorSkin.Scene);
        public const string MiniToolbarButton = "MiniToolbarButton";
        public static GUIStyle MiniToolbarButton_Game => Get(MiniToolbarButton, EditorSkin.Game);
        public static GUIStyle MiniToolbarButton_Inspector => Get(MiniToolbarButton, EditorSkin.Inspector);
        public static GUIStyle MiniToolbarButton_Scene => Get(MiniToolbarButton, EditorSkin.Scene);
        public const string MiniToolbarButtonLeft = "MiniToolbarButtonLeft";
        public static GUIStyle MiniToolbarButtonLeft_Game => Get(MiniToolbarButtonLeft, EditorSkin.Game);
        public static GUIStyle MiniToolbarButtonLeft_Inspector => Get(MiniToolbarButtonLeft, EditorSkin.Inspector);
        public static GUIStyle MiniToolbarButtonLeft_Scene => Get(MiniToolbarButtonLeft, EditorSkin.Scene);
        public const string MinMaxHorizontalSliderThumb = "MinMaxHorizontalSliderThumb";
        public static GUIStyle MinMaxHorizontalSliderThumb_Game => Get(MinMaxHorizontalSliderThumb, EditorSkin.Game);

        public static GUIStyle MinMaxHorizontalSliderThumb_Inspector =>
            Get(MinMaxHorizontalSliderThumb, EditorSkin.Inspector);

        public static GUIStyle MinMaxHorizontalSliderThumb_Scene => Get(MinMaxHorizontalSliderThumb, EditorSkin.Scene);
        public const string MultiColumnArrow = "MultiColumnArrow";
        public static GUIStyle MultiColumnArrow_Game => Get(MultiColumnArrow, EditorSkin.Game);
        public static GUIStyle MultiColumnArrow_Inspector => Get(MultiColumnArrow, EditorSkin.Inspector);
        public static GUIStyle MultiColumnArrow_Scene => Get(MultiColumnArrow, EditorSkin.Scene);
        public const string MultiColumnHeader = "MultiColumnHeader";
        public static GUIStyle MultiColumnHeader_Game => Get(MultiColumnHeader, EditorSkin.Game);
        public static GUIStyle MultiColumnHeader_Inspector => Get(MultiColumnHeader, EditorSkin.Inspector);
        public static GUIStyle MultiColumnHeader_Scene => Get(MultiColumnHeader, EditorSkin.Scene);
        public const string MultiColumnHeaderCenter = "MultiColumnHeaderCenter";
        public static GUIStyle MultiColumnHeaderCenter_Game => Get(MultiColumnHeaderCenter, EditorSkin.Game);
        public static GUIStyle MultiColumnHeaderCenter_Inspector => Get(MultiColumnHeaderCenter, EditorSkin.Inspector);
        public static GUIStyle MultiColumnHeaderCenter_Scene => Get(MultiColumnHeaderCenter, EditorSkin.Scene);
        public const string MultiColumnHeaderRight = "MultiColumnHeaderRight";
        public static GUIStyle MultiColumnHeaderRight_Game => Get(MultiColumnHeaderRight, EditorSkin.Game);
        public static GUIStyle MultiColumnHeaderRight_Inspector => Get(MultiColumnHeaderRight, EditorSkin.Inspector);
        public static GUIStyle MultiColumnHeaderRight_Scene => Get(MultiColumnHeaderRight, EditorSkin.Scene);
        public const string MultiColumnTopBar = "MultiColumnTopBar";
        public static GUIStyle MultiColumnTopBar_Game => Get(MultiColumnTopBar, EditorSkin.Game);
        public static GUIStyle MultiColumnTopBar_Inspector => Get(MultiColumnTopBar, EditorSkin.Inspector);
        public static GUIStyle MultiColumnTopBar_Scene => Get(MultiColumnTopBar, EditorSkin.Scene);
        public const string MuteToggle = "MuteToggle";
        public static GUIStyle MuteToggle_Game => Get(MuteToggle, EditorSkin.Game);
        public static GUIStyle MuteToggle_Inspector => Get(MuteToggle, EditorSkin.Inspector);
        public static GUIStyle MuteToggle_Scene => Get(MuteToggle, EditorSkin.Scene);
        public const string NotificationBackground = "NotificationBackground";
        public static GUIStyle NotificationBackground_Game => Get(NotificationBackground, EditorSkin.Game);
        public static GUIStyle NotificationBackground_Inspector => Get(NotificationBackground, EditorSkin.Inspector);
        public static GUIStyle NotificationBackground_Scene => Get(NotificationBackground, EditorSkin.Scene);
        public const string NotificationText = "NotificationText";
        public static GUIStyle NotificationText_Game => Get(NotificationText, EditorSkin.Game);
        public static GUIStyle NotificationText_Inspector => Get(NotificationText, EditorSkin.Inspector);
        public static GUIStyle NotificationText_Scene => Get(NotificationText, EditorSkin.Scene);
        public const string ObjectField = "ObjectField";
        public static GUIStyle ObjectField_Game => Get(ObjectField, EditorSkin.Game);
        public static GUIStyle ObjectField_Inspector => Get(ObjectField, EditorSkin.Inspector);
        public static GUIStyle ObjectField_Scene => Get(ObjectField, EditorSkin.Scene);
        public const string ObjectFieldButton = "ObjectFieldButton";
        public static GUIStyle ObjectFieldButton_Game => Get(ObjectFieldButton, EditorSkin.Game);
        public static GUIStyle ObjectFieldButton_Inspector => Get(ObjectFieldButton, EditorSkin.Inspector);
        public static GUIStyle ObjectFieldButton_Scene => Get(ObjectFieldButton, EditorSkin.Scene);
        public const string ObjectFieldMiniThumb = "ObjectFieldMiniThumb";
        public static GUIStyle ObjectFieldMiniThumb_Game => Get(ObjectFieldMiniThumb, EditorSkin.Game);
        public static GUIStyle ObjectFieldMiniThumb_Inspector => Get(ObjectFieldMiniThumb, EditorSkin.Inspector);
        public static GUIStyle ObjectFieldMiniThumb_Scene => Get(ObjectFieldMiniThumb, EditorSkin.Scene);
        public const string ObjectFieldThumb = "ObjectFieldThumb";
        public static GUIStyle ObjectFieldThumb_Game => Get(ObjectFieldThumb, EditorSkin.Game);
        public static GUIStyle ObjectFieldThumb_Inspector => Get(ObjectFieldThumb, EditorSkin.Inspector);
        public static GUIStyle ObjectFieldThumb_Scene => Get(ObjectFieldThumb, EditorSkin.Scene);
        public const string ObjectFieldThumbLightmapPreviewOverlay = "ObjectFieldThumbLightmapPreviewOverlay";

        public static GUIStyle ObjectFieldThumbLightmapPreviewOverlay_Game =>
            Get(ObjectFieldThumbLightmapPreviewOverlay, EditorSkin.Game);

        public static GUIStyle ObjectFieldThumbLightmapPreviewOverlay_Inspector =>
            Get(ObjectFieldThumbLightmapPreviewOverlay, EditorSkin.Inspector);

        public static GUIStyle ObjectFieldThumbLightmapPreviewOverlay_Scene =>
            Get(ObjectFieldThumbLightmapPreviewOverlay, EditorSkin.Scene);

        public const string ObjectFieldThumbOverlay = "ObjectFieldThumbOverlay";
        public static GUIStyle ObjectFieldThumbOverlay_Game => Get(ObjectFieldThumbOverlay, EditorSkin.Game);
        public static GUIStyle ObjectFieldThumbOverlay_Inspector => Get(ObjectFieldThumbOverlay, EditorSkin.Inspector);
        public static GUIStyle ObjectFieldThumbOverlay_Scene => Get(ObjectFieldThumbOverlay, EditorSkin.Scene);
        public const string ObjectFieldThumbOverlay2 = "ObjectFieldThumbOverlay2";
        public static GUIStyle ObjectFieldThumbOverlay2_Game => Get(ObjectFieldThumbOverlay2, EditorSkin.Game);

        public static GUIStyle ObjectFieldThumbOverlay2_Inspector =>
            Get(ObjectFieldThumbOverlay2, EditorSkin.Inspector);

        public static GUIStyle ObjectFieldThumbOverlay2_Scene => Get(ObjectFieldThumbOverlay2, EditorSkin.Scene);
        public const string ObjectPickerBackground = "ObjectPickerBackground";
        public static GUIStyle ObjectPickerBackground_Game => Get(ObjectPickerBackground, EditorSkin.Game);
        public static GUIStyle ObjectPickerBackground_Inspector => Get(ObjectPickerBackground, EditorSkin.Inspector);
        public static GUIStyle ObjectPickerBackground_Scene => Get(ObjectPickerBackground, EditorSkin.Scene);
        public const string ObjectPickerLargeStatus = "ObjectPickerLargeStatus";
        public static GUIStyle ObjectPickerLargeStatus_Game => Get(ObjectPickerLargeStatus, EditorSkin.Game);
        public static GUIStyle ObjectPickerLargeStatus_Inspector => Get(ObjectPickerLargeStatus, EditorSkin.Inspector);
        public static GUIStyle ObjectPickerLargeStatus_Scene => Get(ObjectPickerLargeStatus, EditorSkin.Scene);
        public const string ObjectPickerPreviewBackground = "ObjectPickerPreviewBackground";

        public static GUIStyle ObjectPickerPreviewBackground_Game =>
            Get(ObjectPickerPreviewBackground, EditorSkin.Game);

        public static GUIStyle ObjectPickerPreviewBackground_Inspector =>
            Get(ObjectPickerPreviewBackground, EditorSkin.Inspector);

        public static GUIStyle ObjectPickerPreviewBackground_Scene =>
            Get(ObjectPickerPreviewBackground, EditorSkin.Scene);

        public const string ObjectPickerResultsEven = "ObjectPickerResultsEven";
        public static GUIStyle ObjectPickerResultsEven_Game => Get(ObjectPickerResultsEven, EditorSkin.Game);
        public static GUIStyle ObjectPickerResultsEven_Inspector => Get(ObjectPickerResultsEven, EditorSkin.Inspector);
        public static GUIStyle ObjectPickerResultsEven_Scene => Get(ObjectPickerResultsEven, EditorSkin.Scene);
        public const string ObjectPickerResultsGrid = "ObjectPickerResultsGrid";
        public static GUIStyle ObjectPickerResultsGrid_Game => Get(ObjectPickerResultsGrid, EditorSkin.Game);
        public static GUIStyle ObjectPickerResultsGrid_Inspector => Get(ObjectPickerResultsGrid, EditorSkin.Inspector);
        public static GUIStyle ObjectPickerResultsGrid_Scene => Get(ObjectPickerResultsGrid, EditorSkin.Scene);
        public const string ObjectPickerResultsOdd = "ObjectPickerResultsOdd";
        public static GUIStyle ObjectPickerResultsOdd_Game => Get(ObjectPickerResultsOdd, EditorSkin.Game);
        public static GUIStyle ObjectPickerResultsOdd_Inspector => Get(ObjectPickerResultsOdd, EditorSkin.Inspector);
        public static GUIStyle ObjectPickerResultsOdd_Scene => Get(ObjectPickerResultsOdd, EditorSkin.Scene);
        public const string ObjectPickerSmallStatus = "ObjectPickerSmallStatus";
        public static GUIStyle ObjectPickerSmallStatus_Game => Get(ObjectPickerSmallStatus, EditorSkin.Game);
        public static GUIStyle ObjectPickerSmallStatus_Inspector => Get(ObjectPickerSmallStatus, EditorSkin.Inspector);
        public static GUIStyle ObjectPickerSmallStatus_Scene => Get(ObjectPickerSmallStatus, EditorSkin.Scene);
        public const string ObjectPickerTab = "ObjectPickerTab";
        public static GUIStyle ObjectPickerTab_Game => Get(ObjectPickerTab, EditorSkin.Game);
        public static GUIStyle ObjectPickerTab_Inspector => Get(ObjectPickerTab, EditorSkin.Inspector);
        public static GUIStyle ObjectPickerTab_Scene => Get(ObjectPickerTab, EditorSkin.Scene);
        public const string ObjectPickerToolbar = "ObjectPickerToolbar";
        public static GUIStyle ObjectPickerToolbar_Game => Get(ObjectPickerToolbar, EditorSkin.Game);
        public static GUIStyle ObjectPickerToolbar_Inspector => Get(ObjectPickerToolbar, EditorSkin.Inspector);
        public static GUIStyle ObjectPickerToolbar_Scene => Get(ObjectPickerToolbar, EditorSkin.Scene);
        public const string OffsetDropDown = "OffsetDropDown";
        public static GUIStyle OffsetDropDown_Game => Get(OffsetDropDown, EditorSkin.Game);
        public static GUIStyle OffsetDropDown_Inspector => Get(OffsetDropDown, EditorSkin.Inspector);
        public static GUIStyle OffsetDropDown_Scene => Get(OffsetDropDown, EditorSkin.Scene);
        public const string OL_box = "OL box";
        public static GUIStyle OL_box_Game => Get(OL_box, EditorSkin.Game);
        public static GUIStyle OL_box_Inspector => Get(OL_box, EditorSkin.Inspector);
        public static GUIStyle OL_box_Scene => Get(OL_box, EditorSkin.Scene);
        public const string OL_box_flat = "OL box flat";
        public static GUIStyle OL_box_flat_Game => Get(OL_box_flat, EditorSkin.Game);
        public static GUIStyle OL_box_flat_Inspector => Get(OL_box_flat, EditorSkin.Inspector);
        public static GUIStyle OL_box_flat_Scene => Get(OL_box_flat, EditorSkin.Scene);
        public const string OL_box_NoExpand = "OL box NoExpand";
        public static GUIStyle OL_box_NoExpand_Game => Get(OL_box_NoExpand, EditorSkin.Game);
        public static GUIStyle OL_box_NoExpand_Inspector => Get(OL_box_NoExpand, EditorSkin.Inspector);
        public static GUIStyle OL_box_NoExpand_Scene => Get(OL_box_NoExpand, EditorSkin.Scene);
        public const string OL_EntryBackEven = "OL EntryBackEven";
        public static GUIStyle OL_EntryBackEven_Game => Get(OL_EntryBackEven, EditorSkin.Game);
        public static GUIStyle OL_EntryBackEven_Inspector => Get(OL_EntryBackEven, EditorSkin.Inspector);
        public static GUIStyle OL_EntryBackEven_Scene => Get(OL_EntryBackEven, EditorSkin.Scene);
        public const string OL_EntryBackOdd = "OL EntryBackOdd";
        public static GUIStyle OL_EntryBackOdd_Game => Get(OL_EntryBackOdd, EditorSkin.Game);
        public static GUIStyle OL_EntryBackOdd_Inspector => Get(OL_EntryBackOdd, EditorSkin.Inspector);
        public static GUIStyle OL_EntryBackOdd_Scene => Get(OL_EntryBackOdd, EditorSkin.Scene);
        public const string OL_Label = "OL Label";
        public static GUIStyle OL_Label_Game => Get(OL_Label, EditorSkin.Game);
        public static GUIStyle OL_Label_Inspector => Get(OL_Label, EditorSkin.Inspector);
        public static GUIStyle OL_Label_Scene => Get(OL_Label, EditorSkin.Scene);
        public const string OL_MiniPing = "OL MiniPing";
        public static GUIStyle OL_MiniPing_Game => Get(OL_MiniPing, EditorSkin.Game);
        public static GUIStyle OL_MiniPing_Inspector => Get(OL_MiniPing, EditorSkin.Inspector);
        public static GUIStyle OL_MiniPing_Scene => Get(OL_MiniPing, EditorSkin.Scene);
        public const string OL_MiniRenameField = "OL MiniRenameField";
        public static GUIStyle OL_MiniRenameField_Game => Get(OL_MiniRenameField, EditorSkin.Game);
        public static GUIStyle OL_MiniRenameField_Inspector => Get(OL_MiniRenameField, EditorSkin.Inspector);
        public static GUIStyle OL_MiniRenameField_Scene => Get(OL_MiniRenameField, EditorSkin.Scene);
        public const string OL_Minus = "OL Minus";
        public static GUIStyle OL_Minus_Game => Get(OL_Minus, EditorSkin.Game);
        public static GUIStyle OL_Minus_Inspector => Get(OL_Minus, EditorSkin.Inspector);
        public static GUIStyle OL_Minus_Scene => Get(OL_Minus, EditorSkin.Scene);
        public const string OL_Ping = "OL Ping";
        public static GUIStyle OL_Ping_Game => Get(OL_Ping, EditorSkin.Game);
        public static GUIStyle OL_Ping_Inspector => Get(OL_Ping, EditorSkin.Inspector);
        public static GUIStyle OL_Ping_Scene => Get(OL_Ping, EditorSkin.Scene);
        public const string OL_Plus = "OL Plus";
        public static GUIStyle OL_Plus_Game => Get(OL_Plus, EditorSkin.Game);
        public static GUIStyle OL_Plus_Inspector => Get(OL_Plus, EditorSkin.Inspector);
        public static GUIStyle OL_Plus_Scene => Get(OL_Plus, EditorSkin.Scene);
        public const string OL_ResultFocusMarker = "OL ResultFocusMarker";
        public static GUIStyle OL_ResultFocusMarker_Game => Get(OL_ResultFocusMarker, EditorSkin.Game);
        public static GUIStyle OL_ResultFocusMarker_Inspector => Get(OL_ResultFocusMarker, EditorSkin.Inspector);
        public static GUIStyle OL_ResultFocusMarker_Scene => Get(OL_ResultFocusMarker, EditorSkin.Scene);
        public const string OL_ResultLabel = "OL ResultLabel";
        public static GUIStyle OL_ResultLabel_Game => Get(OL_ResultLabel, EditorSkin.Game);
        public static GUIStyle OL_ResultLabel_Inspector => Get(OL_ResultLabel, EditorSkin.Inspector);
        public static GUIStyle OL_ResultLabel_Scene => Get(OL_ResultLabel, EditorSkin.Scene);
        public const string OL_RightLabel = "OL RightLabel";
        public static GUIStyle OL_RightLabel_Game => Get(OL_RightLabel, EditorSkin.Game);
        public static GUIStyle OL_RightLabel_Inspector => Get(OL_RightLabel, EditorSkin.Inspector);
        public static GUIStyle OL_RightLabel_Scene => Get(OL_RightLabel, EditorSkin.Scene);
        public const string OL_SelectedRow = "OL SelectedRow";
        public static GUIStyle OL_SelectedRow_Game => Get(OL_SelectedRow, EditorSkin.Game);
        public static GUIStyle OL_SelectedRow_Inspector => Get(OL_SelectedRow, EditorSkin.Inspector);
        public static GUIStyle OL_SelectedRow_Scene => Get(OL_SelectedRow, EditorSkin.Scene);
        public const string OL_Title = "OL Title";
        public static GUIStyle OL_Title_Game => Get(OL_Title, EditorSkin.Game);
        public static GUIStyle OL_Title_Inspector => Get(OL_Title, EditorSkin.Inspector);
        public static GUIStyle OL_Title_Scene => Get(OL_Title, EditorSkin.Scene);
        public const string OL_Title_TextRight = "OL Title TextRight";
        public static GUIStyle OL_Title_TextRight_Game => Get(OL_Title_TextRight, EditorSkin.Game);
        public static GUIStyle OL_Title_TextRight_Inspector => Get(OL_Title_TextRight, EditorSkin.Inspector);
        public static GUIStyle OL_Title_TextRight_Scene => Get(OL_Title_TextRight, EditorSkin.Scene);
        public const string OL_Toggle = "OL Toggle";
        public static GUIStyle OL_Toggle_Game => Get(OL_Toggle, EditorSkin.Game);
        public static GUIStyle OL_Toggle_Inspector => Get(OL_Toggle, EditorSkin.Inspector);
        public static GUIStyle OL_Toggle_Scene => Get(OL_Toggle, EditorSkin.Scene);
        public const string OL_ToggleMixed = "OL ToggleMixed";
        public static GUIStyle OL_ToggleMixed_Game => Get(OL_ToggleMixed, EditorSkin.Game);
        public static GUIStyle OL_ToggleMixed_Inspector => Get(OL_ToggleMixed, EditorSkin.Inspector);
        public static GUIStyle OL_ToggleMixed_Scene => Get(OL_ToggleMixed, EditorSkin.Scene);
        public const string OL_ToggleWhite = "OL ToggleWhite";
        public static GUIStyle OL_ToggleWhite_Game => Get(OL_ToggleWhite, EditorSkin.Game);
        public static GUIStyle OL_ToggleWhite_Inspector => Get(OL_ToggleWhite, EditorSkin.Inspector);
        public static GUIStyle OL_ToggleWhite_Scene => Get(OL_ToggleWhite, EditorSkin.Scene);
        public const string OT_BottomBar = "OT BottomBar";
        public static GUIStyle OT_BottomBar_Game => Get(OT_BottomBar, EditorSkin.Game);
        public static GUIStyle OT_BottomBar_Inspector => Get(OT_BottomBar, EditorSkin.Inspector);
        public static GUIStyle OT_BottomBar_Scene => Get(OT_BottomBar, EditorSkin.Scene);
        public const string OT_TopBar = "OT TopBar";
        public static GUIStyle OT_TopBar_Game => Get(OT_TopBar, EditorSkin.Game);
        public static GUIStyle OT_TopBar_Inspector => Get(OT_TopBar, EditorSkin.Inspector);
        public static GUIStyle OT_TopBar_Scene => Get(OT_TopBar, EditorSkin.Scene);
        public const string OverrideMargin = "OverrideMargin";
        public static GUIStyle OverrideMargin_Game => Get(OverrideMargin, EditorSkin.Game);
        public static GUIStyle OverrideMargin_Inspector => Get(OverrideMargin, EditorSkin.Inspector);
        public static GUIStyle OverrideMargin_Scene => Get(OverrideMargin, EditorSkin.Scene);
        public const string PaneOptions = "PaneOptions";
        public static GUIStyle PaneOptions_Game => Get(PaneOptions, EditorSkin.Game);
        public static GUIStyle PaneOptions_Inspector => Get(PaneOptions, EditorSkin.Inspector);
        public static GUIStyle PaneOptions_Scene => Get(PaneOptions, EditorSkin.Scene);
        public const string PlayerSettingsLevel = "PlayerSettingsLevel";
        public static GUIStyle PlayerSettingsLevel_Game => Get(PlayerSettingsLevel, EditorSkin.Game);
        public static GUIStyle PlayerSettingsLevel_Inspector => Get(PlayerSettingsLevel, EditorSkin.Inspector);
        public static GUIStyle PlayerSettingsLevel_Scene => Get(PlayerSettingsLevel, EditorSkin.Scene);
        public const string PlayerSettingsPlatform = "PlayerSettingsPlatform";
        public static GUIStyle PlayerSettingsPlatform_Game => Get(PlayerSettingsPlatform, EditorSkin.Game);
        public static GUIStyle PlayerSettingsPlatform_Inspector => Get(PlayerSettingsPlatform, EditorSkin.Inspector);
        public static GUIStyle PlayerSettingsPlatform_Scene => Get(PlayerSettingsPlatform, EditorSkin.Scene);
        public const string Popup = "Popup";
        public static GUIStyle Popup_Game => Get(Popup, EditorSkin.Game);
        public static GUIStyle Popup_Inspector => Get(Popup, EditorSkin.Inspector);
        public static GUIStyle Popup_Scene => Get(Popup, EditorSkin.Scene);
        public const string PopupCurveDropdown = "PopupCurveDropdown";
        public static GUIStyle PopupCurveDropdown_Game => Get(PopupCurveDropdown, EditorSkin.Game);
        public static GUIStyle PopupCurveDropdown_Inspector => Get(PopupCurveDropdown, EditorSkin.Inspector);
        public static GUIStyle PopupCurveDropdown_Scene => Get(PopupCurveDropdown, EditorSkin.Scene);
        public const string PopupCurveEditorBackground = "PopupCurveEditorBackground";
        public static GUIStyle PopupCurveEditorBackground_Game => Get(PopupCurveEditorBackground, EditorSkin.Game);

        public static GUIStyle PopupCurveEditorBackground_Inspector =>
            Get(PopupCurveEditorBackground, EditorSkin.Inspector);

        public static GUIStyle PopupCurveEditorBackground_Scene => Get(PopupCurveEditorBackground, EditorSkin.Scene);
        public const string PopupCurveEditorSwatch = "PopupCurveEditorSwatch";
        public static GUIStyle PopupCurveEditorSwatch_Game => Get(PopupCurveEditorSwatch, EditorSkin.Game);
        public static GUIStyle PopupCurveEditorSwatch_Inspector => Get(PopupCurveEditorSwatch, EditorSkin.Inspector);
        public static GUIStyle PopupCurveEditorSwatch_Scene => Get(PopupCurveEditorSwatch, EditorSkin.Scene);
        public const string PopupCurveSwatchBackground = "PopupCurveSwatchBackground";
        public static GUIStyle PopupCurveSwatchBackground_Game => Get(PopupCurveSwatchBackground, EditorSkin.Game);

        public static GUIStyle PopupCurveSwatchBackground_Inspector =>
            Get(PopupCurveSwatchBackground, EditorSkin.Inspector);

        public static GUIStyle PopupCurveSwatchBackground_Scene => Get(PopupCurveSwatchBackground, EditorSkin.Scene);
        public const string PR_BrokenPrefabLabel = "PR BrokenPrefabLabel";
        public static GUIStyle PR_BrokenPrefabLabel_Game => Get(PR_BrokenPrefabLabel, EditorSkin.Game);
        public static GUIStyle PR_BrokenPrefabLabel_Inspector => Get(PR_BrokenPrefabLabel, EditorSkin.Inspector);
        public static GUIStyle PR_BrokenPrefabLabel_Scene => Get(PR_BrokenPrefabLabel, EditorSkin.Scene);
        public const string PR_DisabledBrokenPrefabLabel = "PR DisabledBrokenPrefabLabel";
        public static GUIStyle PR_DisabledBrokenPrefabLabel_Game => Get(PR_DisabledBrokenPrefabLabel, EditorSkin.Game);

        public static GUIStyle PR_DisabledBrokenPrefabLabel_Inspector =>
            Get(PR_DisabledBrokenPrefabLabel, EditorSkin.Inspector);

        public static GUIStyle PR_DisabledBrokenPrefabLabel_Scene =>
            Get(PR_DisabledBrokenPrefabLabel, EditorSkin.Scene);

        public const string PR_DisabledLabel = "PR DisabledLabel";
        public static GUIStyle PR_DisabledLabel_Game => Get(PR_DisabledLabel, EditorSkin.Game);
        public static GUIStyle PR_DisabledLabel_Inspector => Get(PR_DisabledLabel, EditorSkin.Inspector);
        public static GUIStyle PR_DisabledLabel_Scene => Get(PR_DisabledLabel, EditorSkin.Scene);
        public const string PR_DisabledPrefabLabel = "PR DisabledPrefabLabel";
        public static GUIStyle PR_DisabledPrefabLabel_Game => Get(PR_DisabledPrefabLabel, EditorSkin.Game);
        public static GUIStyle PR_DisabledPrefabLabel_Inspector => Get(PR_DisabledPrefabLabel, EditorSkin.Inspector);
        public static GUIStyle PR_DisabledPrefabLabel_Scene => Get(PR_DisabledPrefabLabel, EditorSkin.Scene);
        public const string PR_Insertion = "PR Insertion";
        public static GUIStyle PR_Insertion_Game => Get(PR_Insertion, EditorSkin.Game);
        public static GUIStyle PR_Insertion_Inspector => Get(PR_Insertion, EditorSkin.Inspector);
        public static GUIStyle PR_Insertion_Scene => Get(PR_Insertion, EditorSkin.Scene);
        public const string PR_Label = "PR Label";
        public static GUIStyle PR_Label_Game => Get(PR_Label, EditorSkin.Game);
        public static GUIStyle PR_Label_Inspector => Get(PR_Label, EditorSkin.Inspector);
        public static GUIStyle PR_Label_Scene => Get(PR_Label, EditorSkin.Scene);
        public const string PR_Ping = "PR Ping";
        public static GUIStyle PR_Ping_Game => Get(PR_Ping, EditorSkin.Game);
        public static GUIStyle PR_Ping_Inspector => Get(PR_Ping, EditorSkin.Inspector);
        public static GUIStyle PR_Ping_Scene => Get(PR_Ping, EditorSkin.Scene);
        public const string PR_PrefabLabel = "PR PrefabLabel";
        public static GUIStyle PR_PrefabLabel_Game => Get(PR_PrefabLabel, EditorSkin.Game);
        public static GUIStyle PR_PrefabLabel_Inspector => Get(PR_PrefabLabel, EditorSkin.Inspector);
        public static GUIStyle PR_PrefabLabel_Scene => Get(PR_PrefabLabel, EditorSkin.Scene);
        public const string PR_TextField = "PR TextField";
        public static GUIStyle PR_TextField_Game => Get(PR_TextField, EditorSkin.Game);
        public static GUIStyle PR_TextField_Inspector => Get(PR_TextField, EditorSkin.Inspector);
        public static GUIStyle PR_TextField_Scene => Get(PR_TextField, EditorSkin.Scene);
        public const string PreBackground = "PreBackground";
        public static GUIStyle PreBackground_Game => Get(PreBackground, EditorSkin.Game);
        public static GUIStyle PreBackground_Inspector => Get(PreBackground, EditorSkin.Inspector);
        public static GUIStyle PreBackground_Scene => Get(PreBackground, EditorSkin.Scene);
        public const string PreBackgroundSolid = "PreBackgroundSolid";
        public static GUIStyle PreBackgroundSolid_Game => Get(PreBackgroundSolid, EditorSkin.Game);
        public static GUIStyle PreBackgroundSolid_Inspector => Get(PreBackgroundSolid, EditorSkin.Inspector);
        public static GUIStyle PreBackgroundSolid_Scene => Get(PreBackgroundSolid, EditorSkin.Scene);
        public const string PreButton = "PreButton";
        public static GUIStyle PreButton_Game => Get(PreButton, EditorSkin.Game);
        public static GUIStyle PreButton_Inspector => Get(PreButton, EditorSkin.Inspector);
        public static GUIStyle PreButton_Scene => Get(PreButton, EditorSkin.Scene);
        public const string PreButtonBlue = "PreButtonBlue";
        public static GUIStyle PreButtonBlue_Game => Get(PreButtonBlue, EditorSkin.Game);
        public static GUIStyle PreButtonBlue_Inspector => Get(PreButtonBlue, EditorSkin.Inspector);
        public static GUIStyle PreButtonBlue_Scene => Get(PreButtonBlue, EditorSkin.Scene);
        public const string PreButtonGreen = "PreButtonGreen";
        public static GUIStyle PreButtonGreen_Game => Get(PreButtonGreen, EditorSkin.Game);
        public static GUIStyle PreButtonGreen_Inspector => Get(PreButtonGreen, EditorSkin.Inspector);
        public static GUIStyle PreButtonGreen_Scene => Get(PreButtonGreen, EditorSkin.Scene);
        public const string PreButtonRed = "PreButtonRed";
        public static GUIStyle PreButtonRed_Game => Get(PreButtonRed, EditorSkin.Game);
        public static GUIStyle PreButtonRed_Inspector => Get(PreButtonRed, EditorSkin.Inspector);
        public static GUIStyle PreButtonRed_Scene => Get(PreButtonRed, EditorSkin.Scene);
        public const string PreDropDown = "PreDropDown";
        public static GUIStyle PreDropDown_Game => Get(PreDropDown, EditorSkin.Game);
        public static GUIStyle PreDropDown_Inspector => Get(PreDropDown, EditorSkin.Inspector);
        public static GUIStyle PreDropDown_Scene => Get(PreDropDown, EditorSkin.Scene);
        public const string PreferencesKeysElement = "PreferencesKeysElement";
        public static GUIStyle PreferencesKeysElement_Game => Get(PreferencesKeysElement, EditorSkin.Game);
        public static GUIStyle PreferencesKeysElement_Inspector => Get(PreferencesKeysElement, EditorSkin.Inspector);
        public static GUIStyle PreferencesKeysElement_Scene => Get(PreferencesKeysElement, EditorSkin.Scene);
        public const string PreferencesSection = "PreferencesSection";
        public static GUIStyle PreferencesSection_Game => Get(PreferencesSection, EditorSkin.Game);
        public static GUIStyle PreferencesSection_Inspector => Get(PreferencesSection, EditorSkin.Inspector);
        public static GUIStyle PreferencesSection_Scene => Get(PreferencesSection, EditorSkin.Scene);
        public const string PreferencesSectionBox = "PreferencesSectionBox";
        public static GUIStyle PreferencesSectionBox_Game => Get(PreferencesSectionBox, EditorSkin.Game);
        public static GUIStyle PreferencesSectionBox_Inspector => Get(PreferencesSectionBox, EditorSkin.Inspector);
        public static GUIStyle PreferencesSectionBox_Scene => Get(PreferencesSectionBox, EditorSkin.Scene);
        public const string PrefixLabel = "PrefixLabel";
        public static GUIStyle PrefixLabel_Game => Get(PrefixLabel, EditorSkin.Game);
        public static GUIStyle PrefixLabel_Inspector => Get(PrefixLabel, EditorSkin.Inspector);
        public static GUIStyle PrefixLabel_Scene => Get(PrefixLabel, EditorSkin.Scene);
        public const string PreHorizontalScrollbar = "PreHorizontalScrollbar";
        public static GUIStyle PreHorizontalScrollbar_Game => Get(PreHorizontalScrollbar, EditorSkin.Game);
        public static GUIStyle PreHorizontalScrollbar_Inspector => Get(PreHorizontalScrollbar, EditorSkin.Inspector);
        public static GUIStyle PreHorizontalScrollbar_Scene => Get(PreHorizontalScrollbar, EditorSkin.Scene);
        public const string PreHorizontalScrollbarThumb = "PreHorizontalScrollbarThumb";
        public static GUIStyle PreHorizontalScrollbarThumb_Game => Get(PreHorizontalScrollbarThumb, EditorSkin.Game);

        public static GUIStyle PreHorizontalScrollbarThumb_Inspector =>
            Get(PreHorizontalScrollbarThumb, EditorSkin.Inspector);

        public static GUIStyle PreHorizontalScrollbarThumb_Scene => Get(PreHorizontalScrollbarThumb, EditorSkin.Scene);
        public const string PreLabel = "PreLabel";
        public static GUIStyle PreLabel_Game => Get(PreLabel, EditorSkin.Game);
        public static GUIStyle PreLabel_Inspector => Get(PreLabel, EditorSkin.Inspector);
        public static GUIStyle PreLabel_Scene => Get(PreLabel, EditorSkin.Scene);
        public const string PreLabelUpper = "PreLabelUpper";
        public static GUIStyle PreLabelUpper_Game => Get(PreLabelUpper, EditorSkin.Game);
        public static GUIStyle PreLabelUpper_Inspector => Get(PreLabelUpper, EditorSkin.Inspector);
        public static GUIStyle PreLabelUpper_Scene => Get(PreLabelUpper, EditorSkin.Scene);
        public const string PreMiniLabel = "PreMiniLabel";
        public static GUIStyle PreMiniLabel_Game => Get(PreMiniLabel, EditorSkin.Game);
        public static GUIStyle PreMiniLabel_Inspector => Get(PreMiniLabel, EditorSkin.Inspector);
        public static GUIStyle PreMiniLabel_Scene => Get(PreMiniLabel, EditorSkin.Scene);
        public const string PreOverlayLabel = "PreOverlayLabel";
        public static GUIStyle PreOverlayLabel_Game => Get(PreOverlayLabel, EditorSkin.Game);
        public static GUIStyle PreOverlayLabel_Inspector => Get(PreOverlayLabel, EditorSkin.Inspector);
        public static GUIStyle PreOverlayLabel_Scene => Get(PreOverlayLabel, EditorSkin.Scene);
        public const string PreSlider = "PreSlider";
        public static GUIStyle PreSlider_Game => Get(PreSlider, EditorSkin.Game);
        public static GUIStyle PreSlider_Inspector => Get(PreSlider, EditorSkin.Inspector);
        public static GUIStyle PreSlider_Scene => Get(PreSlider, EditorSkin.Scene);
        public const string PreSliderThumb = "PreSliderThumb";
        public static GUIStyle PreSliderThumb_Game => Get(PreSliderThumb, EditorSkin.Game);
        public static GUIStyle PreSliderThumb_Inspector => Get(PreSliderThumb, EditorSkin.Inspector);
        public static GUIStyle PreSliderThumb_Scene => Get(PreSliderThumb, EditorSkin.Scene);
        public const string PreToolbar = "PreToolbar";
        public static GUIStyle PreToolbar_Game => Get(PreToolbar, EditorSkin.Game);
        public static GUIStyle PreToolbar_Inspector => Get(PreToolbar, EditorSkin.Inspector);
        public static GUIStyle PreToolbar_Scene => Get(PreToolbar, EditorSkin.Scene);
        public const string PreToolbar2 = "PreToolbar2";
        public static GUIStyle PreToolbar2_Game => Get(PreToolbar2, EditorSkin.Game);
        public static GUIStyle PreToolbar2_Inspector => Get(PreToolbar2, EditorSkin.Inspector);
        public static GUIStyle PreToolbar2_Scene => Get(PreToolbar2, EditorSkin.Scene);
        public const string PreVerticalScrollbar = "PreVerticalScrollbar";
        public static GUIStyle PreVerticalScrollbar_Game => Get(PreVerticalScrollbar, EditorSkin.Game);
        public static GUIStyle PreVerticalScrollbar_Inspector => Get(PreVerticalScrollbar, EditorSkin.Inspector);
        public static GUIStyle PreVerticalScrollbar_Scene => Get(PreVerticalScrollbar, EditorSkin.Scene);
        public const string PreVerticalScrollbarThumb = "PreVerticalScrollbarThumb";
        public static GUIStyle PreVerticalScrollbarThumb_Game => Get(PreVerticalScrollbarThumb, EditorSkin.Game);

        public static GUIStyle PreVerticalScrollbarThumb_Inspector =>
            Get(PreVerticalScrollbarThumb, EditorSkin.Inspector);

        public static GUIStyle PreVerticalScrollbarThumb_Scene => Get(PreVerticalScrollbarThumb, EditorSkin.Scene);
        public const string PreviewPackageInUse = "PreviewPackageInUse";
        public static GUIStyle PreviewPackageInUse_Game => Get(PreviewPackageInUse, EditorSkin.Game);
        public static GUIStyle PreviewPackageInUse_Inspector => Get(PreviewPackageInUse, EditorSkin.Inspector);
        public static GUIStyle PreviewPackageInUse_Scene => Get(PreviewPackageInUse, EditorSkin.Scene);
        public const string ProfilerBadge = "ProfilerBadge";
        public static GUIStyle ProfilerBadge_Game => Get(ProfilerBadge, EditorSkin.Game);
        public static GUIStyle ProfilerBadge_Inspector => Get(ProfilerBadge, EditorSkin.Inspector);
        public static GUIStyle ProfilerBadge_Scene => Get(ProfilerBadge, EditorSkin.Scene);
        public const string ProfilerDetailViewBackground = "ProfilerDetailViewBackground";
        public static GUIStyle ProfilerDetailViewBackground_Game => Get(ProfilerDetailViewBackground, EditorSkin.Game);

        public static GUIStyle ProfilerDetailViewBackground_Inspector =>
            Get(ProfilerDetailViewBackground, EditorSkin.Inspector);

        public static GUIStyle ProfilerDetailViewBackground_Scene =>
            Get(ProfilerDetailViewBackground, EditorSkin.Scene);

        public const string ProfilerGraphBackground = "ProfilerGraphBackground";
        public static GUIStyle ProfilerGraphBackground_Game => Get(ProfilerGraphBackground, EditorSkin.Game);
        public static GUIStyle ProfilerGraphBackground_Inspector => Get(ProfilerGraphBackground, EditorSkin.Inspector);
        public static GUIStyle ProfilerGraphBackground_Scene => Get(ProfilerGraphBackground, EditorSkin.Scene);
        public const string ProfilerHeaderLabel = "ProfilerHeaderLabel";
        public static GUIStyle ProfilerHeaderLabel_Game => Get(ProfilerHeaderLabel, EditorSkin.Game);
        public static GUIStyle ProfilerHeaderLabel_Inspector => Get(ProfilerHeaderLabel, EditorSkin.Inspector);
        public static GUIStyle ProfilerHeaderLabel_Scene => Get(ProfilerHeaderLabel, EditorSkin.Scene);
        public const string ProfilerLeftPane = "ProfilerLeftPane";
        public static GUIStyle ProfilerLeftPane_Game => Get(ProfilerLeftPane, EditorSkin.Game);
        public static GUIStyle ProfilerLeftPane_Inspector => Get(ProfilerLeftPane, EditorSkin.Inspector);
        public static GUIStyle ProfilerLeftPane_Scene => Get(ProfilerLeftPane, EditorSkin.Scene);
        public const string ProfilerNoDataAvailable = "ProfilerNoDataAvailable";
        public static GUIStyle ProfilerNoDataAvailable_Game => Get(ProfilerNoDataAvailable, EditorSkin.Game);
        public static GUIStyle ProfilerNoDataAvailable_Inspector => Get(ProfilerNoDataAvailable, EditorSkin.Inspector);
        public static GUIStyle ProfilerNoDataAvailable_Scene => Get(ProfilerNoDataAvailable, EditorSkin.Scene);
        public const string ProfilerNotSupportedWarningLabel = "ProfilerNotSupportedWarningLabel";

        public static GUIStyle ProfilerNotSupportedWarningLabel_Game =>
            Get(ProfilerNotSupportedWarningLabel, EditorSkin.Game);

        public static GUIStyle ProfilerNotSupportedWarningLabel_Inspector =>
            Get(ProfilerNotSupportedWarningLabel, EditorSkin.Inspector);

        public static GUIStyle ProfilerNotSupportedWarningLabel_Scene =>
            Get(ProfilerNotSupportedWarningLabel, EditorSkin.Scene);

        public const string ProfilerPaneSubLabel = "ProfilerPaneSubLabel";
        public static GUIStyle ProfilerPaneSubLabel_Game => Get(ProfilerPaneSubLabel, EditorSkin.Game);
        public static GUIStyle ProfilerPaneSubLabel_Inspector => Get(ProfilerPaneSubLabel, EditorSkin.Inspector);
        public static GUIStyle ProfilerPaneSubLabel_Scene => Get(ProfilerPaneSubLabel, EditorSkin.Scene);
        public const string ProfilerRightPane = "ProfilerRightPane";
        public static GUIStyle ProfilerRightPane_Game => Get(ProfilerRightPane, EditorSkin.Game);
        public static GUIStyle ProfilerRightPane_Inspector => Get(ProfilerRightPane, EditorSkin.Inspector);
        public static GUIStyle ProfilerRightPane_Scene => Get(ProfilerRightPane, EditorSkin.Scene);
        public const string ProfilerScrollviewBackground = "ProfilerScrollviewBackground";
        public static GUIStyle ProfilerScrollviewBackground_Game => Get(ProfilerScrollviewBackground, EditorSkin.Game);

        public static GUIStyle ProfilerScrollviewBackground_Inspector =>
            Get(ProfilerScrollviewBackground, EditorSkin.Inspector);

        public static GUIStyle ProfilerScrollviewBackground_Scene =>
            Get(ProfilerScrollviewBackground, EditorSkin.Scene);

        public const string ProfilerSelectedLabel = "ProfilerSelectedLabel";
        public static GUIStyle ProfilerSelectedLabel_Game => Get(ProfilerSelectedLabel, EditorSkin.Game);
        public static GUIStyle ProfilerSelectedLabel_Inspector => Get(ProfilerSelectedLabel, EditorSkin.Inspector);
        public static GUIStyle ProfilerSelectedLabel_Scene => Get(ProfilerSelectedLabel, EditorSkin.Scene);
        public const string ProfilerTimelineBar = "ProfilerTimelineBar";
        public static GUIStyle ProfilerTimelineBar_Game => Get(ProfilerTimelineBar, EditorSkin.Game);
        public static GUIStyle ProfilerTimelineBar_Inspector => Get(ProfilerTimelineBar, EditorSkin.Inspector);
        public static GUIStyle ProfilerTimelineBar_Scene => Get(ProfilerTimelineBar, EditorSkin.Scene);
        public const string ProfilerTimelineDigDownArrow = "ProfilerTimelineDigDownArrow";
        public static GUIStyle ProfilerTimelineDigDownArrow_Game => Get(ProfilerTimelineDigDownArrow, EditorSkin.Game);

        public static GUIStyle ProfilerTimelineDigDownArrow_Inspector =>
            Get(ProfilerTimelineDigDownArrow, EditorSkin.Inspector);

        public static GUIStyle ProfilerTimelineDigDownArrow_Scene =>
            Get(ProfilerTimelineDigDownArrow, EditorSkin.Scene);

        public const string ProfilerTimelineFoldout = "ProfilerTimelineFoldout";
        public static GUIStyle ProfilerTimelineFoldout_Game => Get(ProfilerTimelineFoldout, EditorSkin.Game);
        public static GUIStyle ProfilerTimelineFoldout_Inspector => Get(ProfilerTimelineFoldout, EditorSkin.Inspector);
        public static GUIStyle ProfilerTimelineFoldout_Scene => Get(ProfilerTimelineFoldout, EditorSkin.Scene);
        public const string ProfilerTimelineLeftPane = "ProfilerTimelineLeftPane";
        public static GUIStyle ProfilerTimelineLeftPane_Game => Get(ProfilerTimelineLeftPane, EditorSkin.Game);

        public static GUIStyle ProfilerTimelineLeftPane_Inspector =>
            Get(ProfilerTimelineLeftPane, EditorSkin.Inspector);

        public static GUIStyle ProfilerTimelineLeftPane_Scene => Get(ProfilerTimelineLeftPane, EditorSkin.Scene);
        public const string ProfilerTimelineRollUpArrow = "ProfilerTimelineRollUpArrow";
        public static GUIStyle ProfilerTimelineRollUpArrow_Game => Get(ProfilerTimelineRollUpArrow, EditorSkin.Game);

        public static GUIStyle ProfilerTimelineRollUpArrow_Inspector =>
            Get(ProfilerTimelineRollUpArrow, EditorSkin.Inspector);

        public static GUIStyle ProfilerTimelineRollUpArrow_Scene => Get(ProfilerTimelineRollUpArrow, EditorSkin.Scene);
        public const string ProgressBarBack = "ProgressBarBack";
        public static GUIStyle ProgressBarBack_Game => Get(ProgressBarBack, EditorSkin.Game);
        public static GUIStyle ProgressBarBack_Inspector => Get(ProgressBarBack, EditorSkin.Inspector);
        public static GUIStyle ProgressBarBack_Scene => Get(ProgressBarBack, EditorSkin.Scene);
        public const string ProgressBarBar = "ProgressBarBar";
        public static GUIStyle ProgressBarBar_Game => Get(ProgressBarBar, EditorSkin.Game);
        public static GUIStyle ProgressBarBar_Inspector => Get(ProgressBarBar, EditorSkin.Inspector);
        public static GUIStyle ProgressBarBar_Scene => Get(ProgressBarBar, EditorSkin.Scene);
        public const string ProgressBarText = "ProgressBarText";
        public static GUIStyle ProgressBarText_Game => Get(ProgressBarText, EditorSkin.Game);
        public static GUIStyle ProgressBarText_Inspector => Get(ProgressBarText, EditorSkin.Inspector);
        public static GUIStyle ProgressBarText_Scene => Get(ProgressBarText, EditorSkin.Scene);
        public const string ProjectBrowserBottomBarBg = "ProjectBrowserBottomBarBg";
        public static GUIStyle ProjectBrowserBottomBarBg_Game => Get(ProjectBrowserBottomBarBg, EditorSkin.Game);

        public static GUIStyle ProjectBrowserBottomBarBg_Inspector =>
            Get(ProjectBrowserBottomBarBg, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserBottomBarBg_Scene => Get(ProjectBrowserBottomBarBg, EditorSkin.Scene);
        public const string ProjectBrowserGridLabel = "ProjectBrowserGridLabel";
        public static GUIStyle ProjectBrowserGridLabel_Game => Get(ProjectBrowserGridLabel, EditorSkin.Game);
        public static GUIStyle ProjectBrowserGridLabel_Inspector => Get(ProjectBrowserGridLabel, EditorSkin.Inspector);
        public static GUIStyle ProjectBrowserGridLabel_Scene => Get(ProjectBrowserGridLabel, EditorSkin.Scene);
        public const string ProjectBrowserHeaderBgMiddle = "ProjectBrowserHeaderBgMiddle";
        public static GUIStyle ProjectBrowserHeaderBgMiddle_Game => Get(ProjectBrowserHeaderBgMiddle, EditorSkin.Game);

        public static GUIStyle ProjectBrowserHeaderBgMiddle_Inspector =>
            Get(ProjectBrowserHeaderBgMiddle, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserHeaderBgMiddle_Scene =>
            Get(ProjectBrowserHeaderBgMiddle, EditorSkin.Scene);

        public const string ProjectBrowserHeaderBgTop = "ProjectBrowserHeaderBgTop";
        public static GUIStyle ProjectBrowserHeaderBgTop_Game => Get(ProjectBrowserHeaderBgTop, EditorSkin.Game);

        public static GUIStyle ProjectBrowserHeaderBgTop_Inspector =>
            Get(ProjectBrowserHeaderBgTop, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserHeaderBgTop_Scene => Get(ProjectBrowserHeaderBgTop, EditorSkin.Scene);
        public const string ProjectBrowserIconAreaBg = "ProjectBrowserIconAreaBg";
        public static GUIStyle ProjectBrowserIconAreaBg_Game => Get(ProjectBrowserIconAreaBg, EditorSkin.Game);

        public static GUIStyle ProjectBrowserIconAreaBg_Inspector =>
            Get(ProjectBrowserIconAreaBg, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserIconAreaBg_Scene => Get(ProjectBrowserIconAreaBg, EditorSkin.Scene);
        public const string ProjectBrowserIconDropShadow = "ProjectBrowserIconDropShadow";
        public static GUIStyle ProjectBrowserIconDropShadow_Game => Get(ProjectBrowserIconDropShadow, EditorSkin.Game);

        public static GUIStyle ProjectBrowserIconDropShadow_Inspector =>
            Get(ProjectBrowserIconDropShadow, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserIconDropShadow_Scene =>
            Get(ProjectBrowserIconDropShadow, EditorSkin.Scene);

        public const string ProjectBrowserPreviewBg = "ProjectBrowserPreviewBg";
        public static GUIStyle ProjectBrowserPreviewBg_Game => Get(ProjectBrowserPreviewBg, EditorSkin.Game);
        public static GUIStyle ProjectBrowserPreviewBg_Inspector => Get(ProjectBrowserPreviewBg, EditorSkin.Inspector);
        public static GUIStyle ProjectBrowserPreviewBg_Scene => Get(ProjectBrowserPreviewBg, EditorSkin.Scene);
        public const string ProjectBrowserSubAssetBg = "ProjectBrowserSubAssetBg";
        public static GUIStyle ProjectBrowserSubAssetBg_Game => Get(ProjectBrowserSubAssetBg, EditorSkin.Game);

        public static GUIStyle ProjectBrowserSubAssetBg_Inspector =>
            Get(ProjectBrowserSubAssetBg, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserSubAssetBg_Scene => Get(ProjectBrowserSubAssetBg, EditorSkin.Scene);
        public const string ProjectBrowserSubAssetBgCloseEnded = "ProjectBrowserSubAssetBgCloseEnded";

        public static GUIStyle ProjectBrowserSubAssetBgCloseEnded_Game =>
            Get(ProjectBrowserSubAssetBgCloseEnded, EditorSkin.Game);

        public static GUIStyle ProjectBrowserSubAssetBgCloseEnded_Inspector =>
            Get(ProjectBrowserSubAssetBgCloseEnded, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserSubAssetBgCloseEnded_Scene =>
            Get(ProjectBrowserSubAssetBgCloseEnded, EditorSkin.Scene);

        public const string ProjectBrowserSubAssetBgDivider = "ProjectBrowserSubAssetBgDivider";

        public static GUIStyle ProjectBrowserSubAssetBgDivider_Game =>
            Get(ProjectBrowserSubAssetBgDivider, EditorSkin.Game);

        public static GUIStyle ProjectBrowserSubAssetBgDivider_Inspector =>
            Get(ProjectBrowserSubAssetBgDivider, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserSubAssetBgDivider_Scene =>
            Get(ProjectBrowserSubAssetBgDivider, EditorSkin.Scene);

        public const string ProjectBrowserSubAssetBgMiddle = "ProjectBrowserSubAssetBgMiddle";

        public static GUIStyle ProjectBrowserSubAssetBgMiddle_Game =>
            Get(ProjectBrowserSubAssetBgMiddle, EditorSkin.Game);

        public static GUIStyle ProjectBrowserSubAssetBgMiddle_Inspector =>
            Get(ProjectBrowserSubAssetBgMiddle, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserSubAssetBgMiddle_Scene =>
            Get(ProjectBrowserSubAssetBgMiddle, EditorSkin.Scene);

        public const string ProjectBrowserSubAssetBgOpenEnded = "ProjectBrowserSubAssetBgOpenEnded";

        public static GUIStyle ProjectBrowserSubAssetBgOpenEnded_Game =>
            Get(ProjectBrowserSubAssetBgOpenEnded, EditorSkin.Game);

        public static GUIStyle ProjectBrowserSubAssetBgOpenEnded_Inspector =>
            Get(ProjectBrowserSubAssetBgOpenEnded, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserSubAssetBgOpenEnded_Scene =>
            Get(ProjectBrowserSubAssetBgOpenEnded, EditorSkin.Scene);

        public const string ProjectBrowserSubAssetExpandBtn = "ProjectBrowserSubAssetExpandBtn";

        public static GUIStyle ProjectBrowserSubAssetExpandBtn_Game =>
            Get(ProjectBrowserSubAssetExpandBtn, EditorSkin.Game);

        public static GUIStyle ProjectBrowserSubAssetExpandBtn_Inspector =>
            Get(ProjectBrowserSubAssetExpandBtn, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserSubAssetExpandBtn_Scene =>
            Get(ProjectBrowserSubAssetExpandBtn, EditorSkin.Scene);

        public const string ProjectBrowserSubAssetExpandBtnMedium = "ProjectBrowserSubAssetExpandBtnMedium";

        public static GUIStyle ProjectBrowserSubAssetExpandBtnMedium_Game =>
            Get(ProjectBrowserSubAssetExpandBtnMedium, EditorSkin.Game);

        public static GUIStyle ProjectBrowserSubAssetExpandBtnMedium_Inspector =>
            Get(ProjectBrowserSubAssetExpandBtnMedium, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserSubAssetExpandBtnMedium_Scene =>
            Get(ProjectBrowserSubAssetExpandBtnMedium, EditorSkin.Scene);

        public const string ProjectBrowserSubAssetExpandBtnSmall = "ProjectBrowserSubAssetExpandBtnSmall";

        public static GUIStyle ProjectBrowserSubAssetExpandBtnSmall_Game =>
            Get(ProjectBrowserSubAssetExpandBtnSmall, EditorSkin.Game);

        public static GUIStyle ProjectBrowserSubAssetExpandBtnSmall_Inspector =>
            Get(ProjectBrowserSubAssetExpandBtnSmall, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserSubAssetExpandBtnSmall_Scene =>
            Get(ProjectBrowserSubAssetExpandBtnSmall, EditorSkin.Scene);

        public const string ProjectBrowserTextureIconDropShadow = "ProjectBrowserTextureIconDropShadow";

        public static GUIStyle ProjectBrowserTextureIconDropShadow_Game =>
            Get(ProjectBrowserTextureIconDropShadow, EditorSkin.Game);

        public static GUIStyle ProjectBrowserTextureIconDropShadow_Inspector =>
            Get(ProjectBrowserTextureIconDropShadow, EditorSkin.Inspector);

        public static GUIStyle ProjectBrowserTextureIconDropShadow_Scene =>
            Get(ProjectBrowserTextureIconDropShadow, EditorSkin.Scene);

        public const string ProjectBrowserTopBarBg = "ProjectBrowserTopBarBg";
        public static GUIStyle ProjectBrowserTopBarBg_Game => Get(ProjectBrowserTopBarBg, EditorSkin.Game);
        public static GUIStyle ProjectBrowserTopBarBg_Inspector => Get(ProjectBrowserTopBarBg, EditorSkin.Inspector);
        public static GUIStyle ProjectBrowserTopBarBg_Scene => Get(ProjectBrowserTopBarBg, EditorSkin.Scene);
        public const string QualitySettingsDefault = "QualitySettingsDefault";
        public static GUIStyle QualitySettingsDefault_Game => Get(QualitySettingsDefault, EditorSkin.Game);
        public static GUIStyle QualitySettingsDefault_Inspector => Get(QualitySettingsDefault, EditorSkin.Inspector);
        public static GUIStyle QualitySettingsDefault_Scene => Get(QualitySettingsDefault, EditorSkin.Scene);
        public const string Radio = "Radio";
        public static GUIStyle Radio_Game => Get(Radio, EditorSkin.Game);
        public static GUIStyle Radio_Inspector => Get(Radio, EditorSkin.Inspector);
        public static GUIStyle Radio_Scene => Get(Radio, EditorSkin.Scene);
        public const string RectangleToolHBar = "RectangleToolHBar";
        public static GUIStyle RectangleToolHBar_Game => Get(RectangleToolHBar, EditorSkin.Game);
        public static GUIStyle RectangleToolHBar_Inspector => Get(RectangleToolHBar, EditorSkin.Inspector);
        public static GUIStyle RectangleToolHBar_Scene => Get(RectangleToolHBar, EditorSkin.Scene);
        public const string RectangleToolHBarLeft = "RectangleToolHBarLeft";
        public static GUIStyle RectangleToolHBarLeft_Game => Get(RectangleToolHBarLeft, EditorSkin.Game);
        public static GUIStyle RectangleToolHBarLeft_Inspector => Get(RectangleToolHBarLeft, EditorSkin.Inspector);
        public static GUIStyle RectangleToolHBarLeft_Scene => Get(RectangleToolHBarLeft, EditorSkin.Scene);
        public const string RectangleToolHBarRight = "RectangleToolHBarRight";
        public static GUIStyle RectangleToolHBarRight_Game => Get(RectangleToolHBarRight, EditorSkin.Game);
        public static GUIStyle RectangleToolHBarRight_Inspector => Get(RectangleToolHBarRight, EditorSkin.Inspector);
        public static GUIStyle RectangleToolHBarRight_Scene => Get(RectangleToolHBarRight, EditorSkin.Scene);
        public const string RectangleToolHighlight = "RectangleToolHighlight";
        public static GUIStyle RectangleToolHighlight_Game => Get(RectangleToolHighlight, EditorSkin.Game);
        public static GUIStyle RectangleToolHighlight_Inspector => Get(RectangleToolHighlight, EditorSkin.Inspector);
        public static GUIStyle RectangleToolHighlight_Scene => Get(RectangleToolHighlight, EditorSkin.Scene);
        public const string RectangleToolRippleLeft = "RectangleToolRippleLeft";
        public static GUIStyle RectangleToolRippleLeft_Game => Get(RectangleToolRippleLeft, EditorSkin.Game);
        public static GUIStyle RectangleToolRippleLeft_Inspector => Get(RectangleToolRippleLeft, EditorSkin.Inspector);
        public static GUIStyle RectangleToolRippleLeft_Scene => Get(RectangleToolRippleLeft, EditorSkin.Scene);
        public const string RectangleToolRippleRight = "RectangleToolRippleRight";
        public static GUIStyle RectangleToolRippleRight_Game => Get(RectangleToolRippleRight, EditorSkin.Game);

        public static GUIStyle RectangleToolRippleRight_Inspector =>
            Get(RectangleToolRippleRight, EditorSkin.Inspector);

        public static GUIStyle RectangleToolRippleRight_Scene => Get(RectangleToolRippleRight, EditorSkin.Scene);
        public const string RectangleToolScaleBottom = "RectangleToolScaleBottom";
        public static GUIStyle RectangleToolScaleBottom_Game => Get(RectangleToolScaleBottom, EditorSkin.Game);

        public static GUIStyle RectangleToolScaleBottom_Inspector =>
            Get(RectangleToolScaleBottom, EditorSkin.Inspector);

        public static GUIStyle RectangleToolScaleBottom_Scene => Get(RectangleToolScaleBottom, EditorSkin.Scene);
        public const string RectangleToolScaleLeft = "RectangleToolScaleLeft";
        public static GUIStyle RectangleToolScaleLeft_Game => Get(RectangleToolScaleLeft, EditorSkin.Game);
        public static GUIStyle RectangleToolScaleLeft_Inspector => Get(RectangleToolScaleLeft, EditorSkin.Inspector);
        public static GUIStyle RectangleToolScaleLeft_Scene => Get(RectangleToolScaleLeft, EditorSkin.Scene);
        public const string RectangleToolScaleRight = "RectangleToolScaleRight";
        public static GUIStyle RectangleToolScaleRight_Game => Get(RectangleToolScaleRight, EditorSkin.Game);
        public static GUIStyle RectangleToolScaleRight_Inspector => Get(RectangleToolScaleRight, EditorSkin.Inspector);
        public static GUIStyle RectangleToolScaleRight_Scene => Get(RectangleToolScaleRight, EditorSkin.Scene);
        public const string RectangleToolScaleTop = "RectangleToolScaleTop";
        public static GUIStyle RectangleToolScaleTop_Game => Get(RectangleToolScaleTop, EditorSkin.Game);
        public static GUIStyle RectangleToolScaleTop_Inspector => Get(RectangleToolScaleTop, EditorSkin.Inspector);
        public static GUIStyle RectangleToolScaleTop_Scene => Get(RectangleToolScaleTop, EditorSkin.Scene);
        public const string RectangleToolSelection = "RectangleToolSelection";
        public static GUIStyle RectangleToolSelection_Game => Get(RectangleToolSelection, EditorSkin.Game);
        public static GUIStyle RectangleToolSelection_Inspector => Get(RectangleToolSelection, EditorSkin.Inspector);
        public static GUIStyle RectangleToolSelection_Scene => Get(RectangleToolSelection, EditorSkin.Scene);
        public const string RectangleToolVBar = "RectangleToolVBar";
        public static GUIStyle RectangleToolVBar_Game => Get(RectangleToolVBar, EditorSkin.Game);
        public static GUIStyle RectangleToolVBar_Inspector => Get(RectangleToolVBar, EditorSkin.Inspector);
        public static GUIStyle RectangleToolVBar_Scene => Get(RectangleToolVBar, EditorSkin.Scene);
        public const string RectangleToolVBarBottom = "RectangleToolVBarBottom";
        public static GUIStyle RectangleToolVBarBottom_Game => Get(RectangleToolVBarBottom, EditorSkin.Game);
        public static GUIStyle RectangleToolVBarBottom_Inspector => Get(RectangleToolVBarBottom, EditorSkin.Inspector);
        public static GUIStyle RectangleToolVBarBottom_Scene => Get(RectangleToolVBarBottom, EditorSkin.Scene);
        public const string RectangleToolVBarTop = "RectangleToolVBarTop";
        public static GUIStyle RectangleToolVBarTop_Game => Get(RectangleToolVBarTop, EditorSkin.Game);
        public static GUIStyle RectangleToolVBarTop_Inspector => Get(RectangleToolVBarTop, EditorSkin.Inspector);
        public static GUIStyle RectangleToolVBarTop_Scene => Get(RectangleToolVBarTop, EditorSkin.Scene);
        public const string RegionBg = "RegionBg";
        public static GUIStyle RegionBg_Game => Get(RegionBg, EditorSkin.Game);
        public static GUIStyle RegionBg_Inspector => Get(RegionBg, EditorSkin.Inspector);
        public static GUIStyle RegionBg_Scene => Get(RegionBg, EditorSkin.Scene);
        public const string ReorderableList = "ReorderableList";
        public static GUIStyle ReorderableList_Game => Get(ReorderableList, EditorSkin.Game);
        public static GUIStyle ReorderableList_Inspector => Get(ReorderableList, EditorSkin.Inspector);
        public static GUIStyle ReorderableList_Scene => Get(ReorderableList, EditorSkin.Scene);
        public const string ReorderableListRightAligned = "ReorderableListRightAligned";
        public static GUIStyle ReorderableListRightAligned_Game => Get(ReorderableListRightAligned, EditorSkin.Game);

        public static GUIStyle ReorderableListRightAligned_Inspector =>
            Get(ReorderableListRightAligned, EditorSkin.Inspector);

        public static GUIStyle ReorderableListRightAligned_Scene => Get(ReorderableListRightAligned, EditorSkin.Scene);
        public const string RightAlignedLabel = "RightAlignedLabel";
        public static GUIStyle RightAlignedLabel_Game => Get(RightAlignedLabel, EditorSkin.Game);
        public static GUIStyle RightAlignedLabel_Inspector => Get(RightAlignedLabel, EditorSkin.Inspector);
        public static GUIStyle RightAlignedLabel_Scene => Get(RightAlignedLabel, EditorSkin.Scene);
        public const string RightLabel = "RightLabel";
        public static GUIStyle RightLabel_Game => Get(RightLabel, EditorSkin.Game);
        public static GUIStyle RightLabel_Inspector => Get(RightLabel, EditorSkin.Inspector);
        public static GUIStyle RightLabel_Scene => Get(RightLabel, EditorSkin.Scene);
        public const string RL_Background = "RL Background";
        public static GUIStyle RL_Background_Game => Get(RL_Background, EditorSkin.Game);
        public static GUIStyle RL_Background_Inspector => Get(RL_Background, EditorSkin.Inspector);
        public static GUIStyle RL_Background_Scene => Get(RL_Background, EditorSkin.Scene);
        public const string RL_DragHandle = "RL DragHandle";
        public static GUIStyle RL_DragHandle_Game => Get(RL_DragHandle, EditorSkin.Game);
        public static GUIStyle RL_DragHandle_Inspector => Get(RL_DragHandle, EditorSkin.Inspector);
        public static GUIStyle RL_DragHandle_Scene => Get(RL_DragHandle, EditorSkin.Scene);
        public const string RL_Element = "RL Element";
        public static GUIStyle RL_Element_Game => Get(RL_Element, EditorSkin.Game);
        public static GUIStyle RL_Element_Inspector => Get(RL_Element, EditorSkin.Inspector);
        public static GUIStyle RL_Element_Scene => Get(RL_Element, EditorSkin.Scene);
        public const string RL_Empty_Header = "RL Empty Header";
        public static GUIStyle RL_Empty_Header_Game => Get(RL_Empty_Header, EditorSkin.Game);
        public static GUIStyle RL_Empty_Header_Inspector => Get(RL_Empty_Header, EditorSkin.Inspector);
        public static GUIStyle RL_Empty_Header_Scene => Get(RL_Empty_Header, EditorSkin.Scene);
        public const string RL_Footer = "RL Footer";
        public static GUIStyle RL_Footer_Game => Get(RL_Footer, EditorSkin.Game);
        public static GUIStyle RL_Footer_Inspector => Get(RL_Footer, EditorSkin.Inspector);
        public static GUIStyle RL_Footer_Scene => Get(RL_Footer, EditorSkin.Scene);
        public const string RL_FooterButton = "RL FooterButton";
        public static GUIStyle RL_FooterButton_Game => Get(RL_FooterButton, EditorSkin.Game);
        public static GUIStyle RL_FooterButton_Inspector => Get(RL_FooterButton, EditorSkin.Inspector);
        public static GUIStyle RL_FooterButton_Scene => Get(RL_FooterButton, EditorSkin.Scene);
        public const string RL_Header = "RL Header";
        public static GUIStyle RL_Header_Game => Get(RL_Header, EditorSkin.Game);
        public static GUIStyle RL_Header_Inspector => Get(RL_Header, EditorSkin.Inspector);
        public static GUIStyle RL_Header_Scene => Get(RL_Header, EditorSkin.Scene);
        public const string SC_ViewAxisLabel = "SC ViewAxisLabel";
        public static GUIStyle SC_ViewAxisLabel_Game => Get(SC_ViewAxisLabel, EditorSkin.Game);
        public static GUIStyle SC_ViewAxisLabel_Inspector => Get(SC_ViewAxisLabel, EditorSkin.Inspector);
        public static GUIStyle SC_ViewAxisLabel_Scene => Get(SC_ViewAxisLabel, EditorSkin.Scene);
        public const string SC_ViewLabel = "SC ViewLabel";
        public static GUIStyle SC_ViewLabel_Game => Get(SC_ViewLabel, EditorSkin.Game);
        public static GUIStyle SC_ViewLabel_Inspector => Get(SC_ViewLabel, EditorSkin.Inspector);
        public static GUIStyle SC_ViewLabel_Scene => Get(SC_ViewLabel, EditorSkin.Scene);
        public const string SC_ViewLabelCentered = "SC ViewLabelCentered";
        public static GUIStyle SC_ViewLabelCentered_Game => Get(SC_ViewLabelCentered, EditorSkin.Game);
        public static GUIStyle SC_ViewLabelCentered_Inspector => Get(SC_ViewLabelCentered, EditorSkin.Inspector);
        public static GUIStyle SC_ViewLabelCentered_Scene => Get(SC_ViewLabelCentered, EditorSkin.Scene);
        public const string SC_ViewLabelLeftAligned = "SC ViewLabelLeftAligned";
        public static GUIStyle SC_ViewLabelLeftAligned_Game => Get(SC_ViewLabelLeftAligned, EditorSkin.Game);
        public static GUIStyle SC_ViewLabelLeftAligned_Inspector => Get(SC_ViewLabelLeftAligned, EditorSkin.Inspector);
        public static GUIStyle SC_ViewLabelLeftAligned_Scene => Get(SC_ViewLabelLeftAligned, EditorSkin.Scene);
        public const string SceneTopBarBg = "SceneTopBarBg";
        public static GUIStyle SceneTopBarBg_Game => Get(SceneTopBarBg, EditorSkin.Game);
        public static GUIStyle SceneTopBarBg_Inspector => Get(SceneTopBarBg, EditorSkin.Inspector);
        public static GUIStyle SceneTopBarBg_Scene => Get(SceneTopBarBg, EditorSkin.Scene);
        public const string SceneViewOverlayTransparentBackground = "SceneViewOverlayTransparentBackground";

        public static GUIStyle SceneViewOverlayTransparentBackground_Game =>
            Get(SceneViewOverlayTransparentBackground, EditorSkin.Game);

        public static GUIStyle SceneViewOverlayTransparentBackground_Inspector =>
            Get(SceneViewOverlayTransparentBackground, EditorSkin.Inspector);

        public static GUIStyle SceneViewOverlayTransparentBackground_Scene =>
            Get(SceneViewOverlayTransparentBackground, EditorSkin.Scene);

        public const string SceneVisibility = "SceneVisibility";
        public static GUIStyle SceneVisibility_Game => Get(SceneVisibility, EditorSkin.Game);
        public static GUIStyle SceneVisibility_Inspector => Get(SceneVisibility, EditorSkin.Inspector);
        public static GUIStyle SceneVisibility_Scene => Get(SceneVisibility, EditorSkin.Scene);
        public const string ScriptText = "ScriptText";
        public static GUIStyle ScriptText_Game => Get(ScriptText, EditorSkin.Game);
        public static GUIStyle ScriptText_Inspector => Get(ScriptText, EditorSkin.Inspector);
        public static GUIStyle ScriptText_Scene => Get(ScriptText, EditorSkin.Scene);
        public const string ScrollViewAlt = "ScrollViewAlt";
        public static GUIStyle ScrollViewAlt_Game => Get(ScrollViewAlt, EditorSkin.Game);
        public static GUIStyle ScrollViewAlt_Inspector => Get(ScrollViewAlt, EditorSkin.Inspector);
        public static GUIStyle ScrollViewAlt_Scene => Get(ScrollViewAlt, EditorSkin.Scene);
        public const string SearchCancelButton = "SearchCancelButton";
        public static GUIStyle SearchCancelButton_Game => Get(SearchCancelButton, EditorSkin.Game);
        public static GUIStyle SearchCancelButton_Inspector => Get(SearchCancelButton, EditorSkin.Inspector);
        public static GUIStyle SearchCancelButton_Scene => Get(SearchCancelButton, EditorSkin.Scene);
        public const string SearchCancelButtonEmpty = "SearchCancelButtonEmpty";
        public static GUIStyle SearchCancelButtonEmpty_Game => Get(SearchCancelButtonEmpty, EditorSkin.Game);
        public static GUIStyle SearchCancelButtonEmpty_Inspector => Get(SearchCancelButtonEmpty, EditorSkin.Inspector);
        public static GUIStyle SearchCancelButtonEmpty_Scene => Get(SearchCancelButtonEmpty, EditorSkin.Scene);
        public const string SearchModeFilter = "SearchModeFilter";
        public static GUIStyle SearchModeFilter_Game => Get(SearchModeFilter, EditorSkin.Game);
        public static GUIStyle SearchModeFilter_Inspector => Get(SearchModeFilter, EditorSkin.Inspector);
        public static GUIStyle SearchModeFilter_Scene => Get(SearchModeFilter, EditorSkin.Scene);
        public const string SearchTextField = "SearchTextField";
        public static GUIStyle SearchTextField_Game => Get(SearchTextField, EditorSkin.Game);
        public static GUIStyle SearchTextField_Inspector => Get(SearchTextField, EditorSkin.Inspector);
        public static GUIStyle SearchTextField_Scene => Get(SearchTextField, EditorSkin.Scene);
        public const string SelectionRect = "SelectionRect";
        public static GUIStyle SelectionRect_Game => Get(SelectionRect, EditorSkin.Game);
        public static GUIStyle SelectionRect_Inspector => Get(SelectionRect, EditorSkin.Inspector);
        public static GUIStyle SelectionRect_Scene => Get(SelectionRect, EditorSkin.Scene);
        public const string SettingsHeader = "SettingsHeader";
        public static GUIStyle SettingsHeader_Game => Get(SettingsHeader, EditorSkin.Game);
        public static GUIStyle SettingsHeader_Inspector => Get(SettingsHeader, EditorSkin.Inspector);
        public static GUIStyle SettingsHeader_Scene => Get(SettingsHeader, EditorSkin.Scene);
        public const string SettingsIconButton = "SettingsIconButton";
        public static GUIStyle SettingsIconButton_Game => Get(SettingsIconButton, EditorSkin.Game);
        public static GUIStyle SettingsIconButton_Inspector => Get(SettingsIconButton, EditorSkin.Inspector);
        public static GUIStyle SettingsIconButton_Scene => Get(SettingsIconButton, EditorSkin.Scene);
        public const string SettingsListItem = "SettingsListItem";
        public static GUIStyle SettingsListItem_Game => Get(SettingsListItem, EditorSkin.Game);
        public static GUIStyle SettingsListItem_Inspector => Get(SettingsListItem, EditorSkin.Inspector);
        public static GUIStyle SettingsListItem_Scene => Get(SettingsListItem, EditorSkin.Scene);
        public const string SettingsTreeItem = "SettingsTreeItem";
        public static GUIStyle SettingsTreeItem_Game => Get(SettingsTreeItem, EditorSkin.Game);
        public static GUIStyle SettingsTreeItem_Inspector => Get(SettingsTreeItem, EditorSkin.Inspector);
        public static GUIStyle SettingsTreeItem_Scene => Get(SettingsTreeItem, EditorSkin.Scene);
        public const string ShurikenCheckMark = "ShurikenCheckMark";
        public static GUIStyle ShurikenCheckMark_Game => Get(ShurikenCheckMark, EditorSkin.Game);
        public static GUIStyle ShurikenCheckMark_Inspector => Get(ShurikenCheckMark, EditorSkin.Inspector);
        public static GUIStyle ShurikenCheckMark_Scene => Get(ShurikenCheckMark, EditorSkin.Scene);
        public const string ShurikenCheckMarkMixed = "ShurikenCheckMarkMixed";
        public static GUIStyle ShurikenCheckMarkMixed_Game => Get(ShurikenCheckMarkMixed, EditorSkin.Game);
        public static GUIStyle ShurikenCheckMarkMixed_Inspector => Get(ShurikenCheckMarkMixed, EditorSkin.Inspector);
        public static GUIStyle ShurikenCheckMarkMixed_Scene => Get(ShurikenCheckMarkMixed, EditorSkin.Scene);
        public const string ShurikenDropdown = "ShurikenDropdown";
        public static GUIStyle ShurikenDropdown_Game => Get(ShurikenDropdown, EditorSkin.Game);
        public static GUIStyle ShurikenDropdown_Inspector => Get(ShurikenDropdown, EditorSkin.Inspector);
        public static GUIStyle ShurikenDropdown_Scene => Get(ShurikenDropdown, EditorSkin.Scene);
        public const string ShurikenEditableLabel = "ShurikenEditableLabel";
        public static GUIStyle ShurikenEditableLabel_Game => Get(ShurikenEditableLabel, EditorSkin.Game);
        public static GUIStyle ShurikenEditableLabel_Inspector => Get(ShurikenEditableLabel, EditorSkin.Inspector);
        public static GUIStyle ShurikenEditableLabel_Scene => Get(ShurikenEditableLabel, EditorSkin.Scene);
        public const string ShurikenEffectBg = "ShurikenEffectBg";
        public static GUIStyle ShurikenEffectBg_Game => Get(ShurikenEffectBg, EditorSkin.Game);
        public static GUIStyle ShurikenEffectBg_Inspector => Get(ShurikenEffectBg, EditorSkin.Inspector);
        public static GUIStyle ShurikenEffectBg_Scene => Get(ShurikenEffectBg, EditorSkin.Scene);
        public const string ShurikenEmitterTitle = "ShurikenEmitterTitle";
        public static GUIStyle ShurikenEmitterTitle_Game => Get(ShurikenEmitterTitle, EditorSkin.Game);
        public static GUIStyle ShurikenEmitterTitle_Inspector => Get(ShurikenEmitterTitle, EditorSkin.Inspector);
        public static GUIStyle ShurikenEmitterTitle_Scene => Get(ShurikenEmitterTitle, EditorSkin.Scene);
        public const string ShurikenLabel = "ShurikenLabel";
        public static GUIStyle ShurikenLabel_Game => Get(ShurikenLabel, EditorSkin.Game);
        public static GUIStyle ShurikenLabel_Inspector => Get(ShurikenLabel, EditorSkin.Inspector);
        public static GUIStyle ShurikenLabel_Scene => Get(ShurikenLabel, EditorSkin.Scene);
        public const string ShurikenMinus = "ShurikenMinus";
        public static GUIStyle ShurikenMinus_Game => Get(ShurikenMinus, EditorSkin.Game);
        public static GUIStyle ShurikenMinus_Inspector => Get(ShurikenMinus, EditorSkin.Inspector);
        public static GUIStyle ShurikenMinus_Scene => Get(ShurikenMinus, EditorSkin.Scene);
        public const string ShurikenModuleBg = "ShurikenModuleBg";
        public static GUIStyle ShurikenModuleBg_Game => Get(ShurikenModuleBg, EditorSkin.Game);
        public static GUIStyle ShurikenModuleBg_Inspector => Get(ShurikenModuleBg, EditorSkin.Inspector);
        public static GUIStyle ShurikenModuleBg_Scene => Get(ShurikenModuleBg, EditorSkin.Scene);
        public const string ShurikenModuleTitle = "ShurikenModuleTitle";
        public static GUIStyle ShurikenModuleTitle_Game => Get(ShurikenModuleTitle, EditorSkin.Game);
        public static GUIStyle ShurikenModuleTitle_Inspector => Get(ShurikenModuleTitle, EditorSkin.Inspector);
        public static GUIStyle ShurikenModuleTitle_Scene => Get(ShurikenModuleTitle, EditorSkin.Scene);
        public const string ShurikenObjectField = "ShurikenObjectField";
        public static GUIStyle ShurikenObjectField_Game => Get(ShurikenObjectField, EditorSkin.Game);
        public static GUIStyle ShurikenObjectField_Inspector => Get(ShurikenObjectField, EditorSkin.Inspector);
        public static GUIStyle ShurikenObjectField_Scene => Get(ShurikenObjectField, EditorSkin.Scene);
        public const string ShurikenPlus = "ShurikenPlus";
        public static GUIStyle ShurikenPlus_Game => Get(ShurikenPlus, EditorSkin.Game);
        public static GUIStyle ShurikenPlus_Inspector => Get(ShurikenPlus, EditorSkin.Inspector);
        public static GUIStyle ShurikenPlus_Scene => Get(ShurikenPlus, EditorSkin.Scene);
        public const string ShurikenPopup = "ShurikenPopup";
        public static GUIStyle ShurikenPopup_Game => Get(ShurikenPopup, EditorSkin.Game);
        public static GUIStyle ShurikenPopup_Inspector => Get(ShurikenPopup, EditorSkin.Inspector);
        public static GUIStyle ShurikenPopup_Scene => Get(ShurikenPopup, EditorSkin.Scene);
        public const string ShurikenToggle = "ShurikenToggle";
        public static GUIStyle ShurikenToggle_Game => Get(ShurikenToggle, EditorSkin.Game);
        public static GUIStyle ShurikenToggle_Inspector => Get(ShurikenToggle, EditorSkin.Inspector);
        public static GUIStyle ShurikenToggle_Scene => Get(ShurikenToggle, EditorSkin.Scene);
        public const string ShurikenToggleMixed = "ShurikenToggleMixed";
        public static GUIStyle ShurikenToggleMixed_Game => Get(ShurikenToggleMixed, EditorSkin.Game);
        public static GUIStyle ShurikenToggleMixed_Inspector => Get(ShurikenToggleMixed, EditorSkin.Inspector);
        public static GUIStyle ShurikenToggleMixed_Scene => Get(ShurikenToggleMixed, EditorSkin.Scene);
        public const string ShurikenValue = "ShurikenValue";
        public static GUIStyle ShurikenValue_Game => Get(ShurikenValue, EditorSkin.Game);
        public static GUIStyle ShurikenValue_Inspector => Get(ShurikenValue, EditorSkin.Inspector);
        public static GUIStyle ShurikenValue_Scene => Get(ShurikenValue, EditorSkin.Scene);
        public const string SliderMixed = "SliderMixed";
        public static GUIStyle SliderMixed_Game => Get(SliderMixed, EditorSkin.Game);
        public static GUIStyle SliderMixed_Inspector => Get(SliderMixed, EditorSkin.Inspector);
        public static GUIStyle SliderMixed_Scene => Get(SliderMixed, EditorSkin.Scene);
        public const string SoloToggle = "SoloToggle";
        public static GUIStyle SoloToggle_Game => Get(SoloToggle, EditorSkin.Game);
        public static GUIStyle SoloToggle_Inspector => Get(SoloToggle, EditorSkin.Inspector);
        public static GUIStyle SoloToggle_Scene => Get(SoloToggle, EditorSkin.Scene);
        public const string StaticDropdown = "StaticDropdown";
        public static GUIStyle StaticDropdown_Game => Get(StaticDropdown, EditorSkin.Game);
        public static GUIStyle StaticDropdown_Inspector => Get(StaticDropdown, EditorSkin.Inspector);
        public static GUIStyle StaticDropdown_Scene => Get(StaticDropdown, EditorSkin.Scene);
        public const string StatusBarIcon = "StatusBarIcon";
        public static GUIStyle StatusBarIcon_Game => Get(StatusBarIcon, EditorSkin.Game);
        public static GUIStyle StatusBarIcon_Inspector => Get(StatusBarIcon, EditorSkin.Inspector);
        public static GUIStyle StatusBarIcon_Scene => Get(StatusBarIcon, EditorSkin.Scene);
        public const string sv_iconselector_back = "sv_iconselector_back";
        public static GUIStyle sv_iconselector_back_Game => Get(sv_iconselector_back, EditorSkin.Game);
        public static GUIStyle sv_iconselector_back_Inspector => Get(sv_iconselector_back, EditorSkin.Inspector);
        public static GUIStyle sv_iconselector_back_Scene => Get(sv_iconselector_back, EditorSkin.Scene);
        public const string sv_iconselector_button = "sv_iconselector_button";
        public static GUIStyle sv_iconselector_button_Game => Get(sv_iconselector_button, EditorSkin.Game);
        public static GUIStyle sv_iconselector_button_Inspector => Get(sv_iconselector_button, EditorSkin.Inspector);
        public static GUIStyle sv_iconselector_button_Scene => Get(sv_iconselector_button, EditorSkin.Scene);
        public const string sv_iconselector_labelselection = "sv_iconselector_labelselection";

        public static GUIStyle sv_iconselector_labelselection_Game =>
            Get(sv_iconselector_labelselection, EditorSkin.Game);

        public static GUIStyle sv_iconselector_labelselection_Inspector =>
            Get(sv_iconselector_labelselection, EditorSkin.Inspector);

        public static GUIStyle sv_iconselector_labelselection_Scene =>
            Get(sv_iconselector_labelselection, EditorSkin.Scene);

        public const string sv_iconselector_selection = "sv_iconselector_selection";
        public static GUIStyle sv_iconselector_selection_Game => Get(sv_iconselector_selection, EditorSkin.Game);

        public static GUIStyle sv_iconselector_selection_Inspector =>
            Get(sv_iconselector_selection, EditorSkin.Inspector);

        public static GUIStyle sv_iconselector_selection_Scene => Get(sv_iconselector_selection, EditorSkin.Scene);
        public const string sv_iconselector_sep = "sv_iconselector_sep";
        public static GUIStyle sv_iconselector_sep_Game => Get(sv_iconselector_sep, EditorSkin.Game);
        public static GUIStyle sv_iconselector_sep_Inspector => Get(sv_iconselector_sep, EditorSkin.Inspector);
        public static GUIStyle sv_iconselector_sep_Scene => Get(sv_iconselector_sep, EditorSkin.Scene);
        public const string sv_label_0 = "sv_label_0";
        public static GUIStyle sv_label_0_Game => Get(sv_label_0, EditorSkin.Game);
        public static GUIStyle sv_label_0_Inspector => Get(sv_label_0, EditorSkin.Inspector);
        public static GUIStyle sv_label_0_Scene => Get(sv_label_0, EditorSkin.Scene);
        public const string sv_label_1 = "sv_label_1";
        public static GUIStyle sv_label_1_Game => Get(sv_label_1, EditorSkin.Game);
        public static GUIStyle sv_label_1_Inspector => Get(sv_label_1, EditorSkin.Inspector);
        public static GUIStyle sv_label_1_Scene => Get(sv_label_1, EditorSkin.Scene);
        public const string sv_label_2 = "sv_label_2";
        public static GUIStyle sv_label_2_Game => Get(sv_label_2, EditorSkin.Game);
        public static GUIStyle sv_label_2_Inspector => Get(sv_label_2, EditorSkin.Inspector);
        public static GUIStyle sv_label_2_Scene => Get(sv_label_2, EditorSkin.Scene);
        public const string sv_label_3 = "sv_label_3";
        public static GUIStyle sv_label_3_Game => Get(sv_label_3, EditorSkin.Game);
        public static GUIStyle sv_label_3_Inspector => Get(sv_label_3, EditorSkin.Inspector);
        public static GUIStyle sv_label_3_Scene => Get(sv_label_3, EditorSkin.Scene);
        public const string sv_label_4 = "sv_label_4";
        public static GUIStyle sv_label_4_Game => Get(sv_label_4, EditorSkin.Game);
        public static GUIStyle sv_label_4_Inspector => Get(sv_label_4, EditorSkin.Inspector);
        public static GUIStyle sv_label_4_Scene => Get(sv_label_4, EditorSkin.Scene);
        public const string sv_label_5 = "sv_label_5";
        public static GUIStyle sv_label_5_Game => Get(sv_label_5, EditorSkin.Game);
        public static GUIStyle sv_label_5_Inspector => Get(sv_label_5, EditorSkin.Inspector);
        public static GUIStyle sv_label_5_Scene => Get(sv_label_5, EditorSkin.Scene);
        public const string sv_label_6 = "sv_label_6";
        public static GUIStyle sv_label_6_Game => Get(sv_label_6, EditorSkin.Game);
        public static GUIStyle sv_label_6_Inspector => Get(sv_label_6, EditorSkin.Inspector);
        public static GUIStyle sv_label_6_Scene => Get(sv_label_6, EditorSkin.Scene);
        public const string sv_label_7 = "sv_label_7";
        public static GUIStyle sv_label_7_Game => Get(sv_label_7, EditorSkin.Game);
        public static GUIStyle sv_label_7_Inspector => Get(sv_label_7, EditorSkin.Inspector);
        public static GUIStyle sv_label_7_Scene => Get(sv_label_7, EditorSkin.Scene);
        public const string Tab_first = "Tab first";
        public static GUIStyle Tab_first_Game => Get(Tab_first, EditorSkin.Game);
        public static GUIStyle Tab_first_Inspector => Get(Tab_first, EditorSkin.Inspector);
        public static GUIStyle Tab_first_Scene => Get(Tab_first, EditorSkin.Scene);
        public const string Tab_last = "Tab last";
        public static GUIStyle Tab_last_Game => Get(Tab_last, EditorSkin.Game);
        public static GUIStyle Tab_last_Inspector => Get(Tab_last, EditorSkin.Inspector);
        public static GUIStyle Tab_last_Scene => Get(Tab_last, EditorSkin.Scene);
        public const string Tab_middle = "Tab middle";
        public static GUIStyle Tab_middle_Game => Get(Tab_middle, EditorSkin.Game);
        public static GUIStyle Tab_middle_Inspector => Get(Tab_middle, EditorSkin.Inspector);
        public static GUIStyle Tab_middle_Scene => Get(Tab_middle, EditorSkin.Scene);
        public const string Tab_onlyOne = "Tab onlyOne";
        public static GUIStyle Tab_onlyOne_Game => Get(Tab_onlyOne, EditorSkin.Game);
        public static GUIStyle Tab_onlyOne_Inspector => Get(Tab_onlyOne, EditorSkin.Inspector);
        public static GUIStyle Tab_onlyOne_Scene => Get(Tab_onlyOne, EditorSkin.Scene);
        public const string TabWindowBackground = "TabWindowBackground";
        public static GUIStyle TabWindowBackground_Game => Get(TabWindowBackground, EditorSkin.Game);
        public static GUIStyle TabWindowBackground_Inspector => Get(TabWindowBackground, EditorSkin.Inspector);
        public static GUIStyle TabWindowBackground_Scene => Get(TabWindowBackground, EditorSkin.Scene);
        public const string Tag_MenuItem = "Tag MenuItem";
        public static GUIStyle Tag_MenuItem_Game => Get(Tag_MenuItem, EditorSkin.Game);
        public static GUIStyle Tag_MenuItem_Inspector => Get(Tag_MenuItem, EditorSkin.Inspector);
        public static GUIStyle Tag_MenuItem_Scene => Get(Tag_MenuItem, EditorSkin.Scene);
        public const string TE_BoxBackground = "TE BoxBackground";
        public static GUIStyle TE_BoxBackground_Game => Get(TE_BoxBackground, EditorSkin.Game);
        public static GUIStyle TE_BoxBackground_Inspector => Get(TE_BoxBackground, EditorSkin.Inspector);
        public static GUIStyle TE_BoxBackground_Scene => Get(TE_BoxBackground, EditorSkin.Scene);
        public const string TE_DefaultTime = "TE DefaultTime";
        public static GUIStyle TE_DefaultTime_Game => Get(TE_DefaultTime, EditorSkin.Game);
        public static GUIStyle TE_DefaultTime_Inspector => Get(TE_DefaultTime, EditorSkin.Inspector);
        public static GUIStyle TE_DefaultTime_Scene => Get(TE_DefaultTime, EditorSkin.Scene);
        public const string TE_DropField = "TE DropField";
        public static GUIStyle TE_DropField_Game => Get(TE_DropField, EditorSkin.Game);
        public static GUIStyle TE_DropField_Inspector => Get(TE_DropField, EditorSkin.Inspector);
        public static GUIStyle TE_DropField_Scene => Get(TE_DropField, EditorSkin.Scene);
        public const string TE_ElementBackground = "TE ElementBackground";
        public static GUIStyle TE_ElementBackground_Game => Get(TE_ElementBackground, EditorSkin.Game);
        public static GUIStyle TE_ElementBackground_Inspector => Get(TE_ElementBackground, EditorSkin.Inspector);
        public static GUIStyle TE_ElementBackground_Scene => Get(TE_ElementBackground, EditorSkin.Scene);
        public const string TE_NodeBackground = "TE NodeBackground";
        public static GUIStyle TE_NodeBackground_Game => Get(TE_NodeBackground, EditorSkin.Game);
        public static GUIStyle TE_NodeBackground_Inspector => Get(TE_NodeBackground, EditorSkin.Inspector);
        public static GUIStyle TE_NodeBackground_Scene => Get(TE_NodeBackground, EditorSkin.Scene);
        public const string TE_NodeBox = "TE NodeBox";
        public static GUIStyle TE_NodeBox_Game => Get(TE_NodeBox, EditorSkin.Game);
        public static GUIStyle TE_NodeBox_Inspector => Get(TE_NodeBox, EditorSkin.Inspector);
        public static GUIStyle TE_NodeBox_Scene => Get(TE_NodeBox, EditorSkin.Scene);
        public const string TE_NodeBoxSelected = "TE NodeBoxSelected";
        public static GUIStyle TE_NodeBoxSelected_Game => Get(TE_NodeBoxSelected, EditorSkin.Game);
        public static GUIStyle TE_NodeBoxSelected_Inspector => Get(TE_NodeBoxSelected, EditorSkin.Inspector);
        public static GUIStyle TE_NodeBoxSelected_Scene => Get(TE_NodeBoxSelected, EditorSkin.Scene);
        public const string TE_NodeLabelBot = "TE NodeLabelBot";
        public static GUIStyle TE_NodeLabelBot_Game => Get(TE_NodeLabelBot, EditorSkin.Game);
        public static GUIStyle TE_NodeLabelBot_Inspector => Get(TE_NodeLabelBot, EditorSkin.Inspector);
        public static GUIStyle TE_NodeLabelBot_Scene => Get(TE_NodeLabelBot, EditorSkin.Scene);
        public const string TE_NodeLabelTop = "TE NodeLabelTop";
        public static GUIStyle TE_NodeLabelTop_Game => Get(TE_NodeLabelTop, EditorSkin.Game);
        public static GUIStyle TE_NodeLabelTop_Inspector => Get(TE_NodeLabelTop, EditorSkin.Inspector);
        public static GUIStyle TE_NodeLabelTop_Scene => Get(TE_NodeLabelTop, EditorSkin.Scene);
        public const string TE_PinLabel = "TE PinLabel";
        public static GUIStyle TE_PinLabel_Game => Get(TE_PinLabel, EditorSkin.Game);
        public static GUIStyle TE_PinLabel_Inspector => Get(TE_PinLabel, EditorSkin.Inspector);
        public static GUIStyle TE_PinLabel_Scene => Get(TE_PinLabel, EditorSkin.Scene);
        public const string TE_Toolbar = "TE Toolbar";
        public static GUIStyle TE_Toolbar_Game => Get(TE_Toolbar, EditorSkin.Game);
        public static GUIStyle TE_Toolbar_Inspector => Get(TE_Toolbar, EditorSkin.Inspector);
        public static GUIStyle TE_Toolbar_Scene => Get(TE_Toolbar, EditorSkin.Scene);
        public const string TE_toolbarbutton = "TE toolbarbutton";
        public static GUIStyle TE_toolbarbutton_Game => Get(TE_toolbarbutton, EditorSkin.Game);
        public static GUIStyle TE_toolbarbutton_Inspector => Get(TE_toolbarbutton, EditorSkin.Inspector);
        public static GUIStyle TE_toolbarbutton_Scene => Get(TE_toolbarbutton, EditorSkin.Scene);
        public const string TE_ToolbarDropDown = "TE ToolbarDropDown";
        public static GUIStyle TE_ToolbarDropDown_Game => Get(TE_ToolbarDropDown, EditorSkin.Game);
        public static GUIStyle TE_ToolbarDropDown_Inspector => Get(TE_ToolbarDropDown, EditorSkin.Inspector);
        public static GUIStyle TE_ToolbarDropDown_Scene => Get(TE_ToolbarDropDown, EditorSkin.Scene);
        public const string TextFieldDropDown = "TextFieldDropDown";
        public static GUIStyle TextFieldDropDown_Game => Get(TextFieldDropDown, EditorSkin.Game);
        public static GUIStyle TextFieldDropDown_Inspector => Get(TextFieldDropDown, EditorSkin.Inspector);
        public static GUIStyle TextFieldDropDown_Scene => Get(TextFieldDropDown, EditorSkin.Scene);
        public const string TextFieldDropDownText = "TextFieldDropDownText";
        public static GUIStyle TextFieldDropDownText_Game => Get(TextFieldDropDownText, EditorSkin.Game);
        public static GUIStyle TextFieldDropDownText_Inspector => Get(TextFieldDropDownText, EditorSkin.Inspector);
        public static GUIStyle TextFieldDropDownText_Scene => Get(TextFieldDropDownText, EditorSkin.Scene);
        public const string TimeAreaToolbar = "TimeAreaToolbar";
        public static GUIStyle TimeAreaToolbar_Game => Get(TimeAreaToolbar, EditorSkin.Game);
        public static GUIStyle TimeAreaToolbar_Inspector => Get(TimeAreaToolbar, EditorSkin.Inspector);
        public static GUIStyle TimeAreaToolbar_Scene => Get(TimeAreaToolbar, EditorSkin.Scene);
        public const string TimeRulerBackground = "TimeRulerBackground";
        public static GUIStyle TimeRulerBackground_Game => Get(TimeRulerBackground, EditorSkin.Game);
        public static GUIStyle TimeRulerBackground_Inspector => Get(TimeRulerBackground, EditorSkin.Inspector);
        public static GUIStyle TimeRulerBackground_Scene => Get(TimeRulerBackground, EditorSkin.Scene);
        public const string TimeScrubber = "TimeScrubber";
        public static GUIStyle TimeScrubber_Game => Get(TimeScrubber, EditorSkin.Game);
        public static GUIStyle TimeScrubber_Inspector => Get(TimeScrubber, EditorSkin.Inspector);
        public static GUIStyle TimeScrubber_Scene => Get(TimeScrubber, EditorSkin.Scene);
        public const string TimeScrubberButton = "TimeScrubberButton";
        public static GUIStyle TimeScrubberButton_Game => Get(TimeScrubberButton, EditorSkin.Game);
        public static GUIStyle TimeScrubberButton_Inspector => Get(TimeScrubberButton, EditorSkin.Inspector);
        public static GUIStyle TimeScrubberButton_Scene => Get(TimeScrubberButton, EditorSkin.Scene);
        public const string Titlebar_Foldout = "Titlebar Foldout";
        public static GUIStyle Titlebar_Foldout_Game => Get(Titlebar_Foldout, EditorSkin.Game);
        public static GUIStyle Titlebar_Foldout_Inspector => Get(Titlebar_Foldout, EditorSkin.Inspector);
        public static GUIStyle Titlebar_Foldout_Scene => Get(Titlebar_Foldout, EditorSkin.Scene);
        public const string TL_InPoint = "TL InPoint";
        public static GUIStyle TL_InPoint_Game => Get(TL_InPoint, EditorSkin.Game);
        public static GUIStyle TL_InPoint_Inspector => Get(TL_InPoint, EditorSkin.Inspector);
        public static GUIStyle TL_InPoint_Scene => Get(TL_InPoint, EditorSkin.Scene);
        public const string TL_OutPoint = "TL OutPoint";
        public static GUIStyle TL_OutPoint_Game => Get(TL_OutPoint, EditorSkin.Game);
        public static GUIStyle TL_OutPoint_Inspector => Get(TL_OutPoint, EditorSkin.Inspector);
        public static GUIStyle TL_OutPoint_Scene => Get(TL_OutPoint, EditorSkin.Scene);
        public const string TL_Playhead = "TL Playhead";
        public static GUIStyle TL_Playhead_Game => Get(TL_Playhead, EditorSkin.Game);
        public static GUIStyle TL_Playhead_Inspector => Get(TL_Playhead, EditorSkin.Inspector);
        public static GUIStyle TL_Playhead_Scene => Get(TL_Playhead, EditorSkin.Scene);
        public const string ToggleMixed = "ToggleMixed";
        public static GUIStyle ToggleMixed_Game => Get(ToggleMixed, EditorSkin.Game);
        public static GUIStyle ToggleMixed_Inspector => Get(ToggleMixed, EditorSkin.Inspector);
        public static GUIStyle ToggleMixed_Scene => Get(ToggleMixed, EditorSkin.Scene);
        public const string Toolbar = "Toolbar";
        public static GUIStyle Toolbar_Game => Get(Toolbar, EditorSkin.Game);
        public static GUIStyle Toolbar_Inspector => Get(Toolbar, EditorSkin.Inspector);
        public static GUIStyle Toolbar_Scene => Get(Toolbar, EditorSkin.Scene);
        public const string ToolbarBoldLabel = "ToolbarBoldLabel";
        public static GUIStyle ToolbarBoldLabel_Game => Get(ToolbarBoldLabel, EditorSkin.Game);
        public static GUIStyle ToolbarBoldLabel_Inspector => Get(ToolbarBoldLabel, EditorSkin.Inspector);
        public static GUIStyle ToolbarBoldLabel_Scene => Get(ToolbarBoldLabel, EditorSkin.Scene);
        public const string ToolbarBottom = "ToolbarBottom";
        public static GUIStyle ToolbarBottom_Game => Get(ToolbarBottom, EditorSkin.Game);
        public static GUIStyle ToolbarBottom_Inspector => Get(ToolbarBottom, EditorSkin.Inspector);
        public static GUIStyle ToolbarBottom_Scene => Get(ToolbarBottom, EditorSkin.Scene);
        public const string toolbarbutton = "toolbarbutton";
        public static GUIStyle toolbarbutton_Game => Get(toolbarbutton, EditorSkin.Game);
        public static GUIStyle toolbarbutton_Inspector => Get(toolbarbutton, EditorSkin.Inspector);
        public static GUIStyle toolbarbutton_Scene => Get(toolbarbutton, EditorSkin.Scene);
        public const string ToolbarButtonFlat = "ToolbarButtonFlat";
        public static GUIStyle ToolbarButtonFlat_Game => Get(ToolbarButtonFlat, EditorSkin.Game);
        public static GUIStyle ToolbarButtonFlat_Inspector => Get(ToolbarButtonFlat, EditorSkin.Inspector);
        public static GUIStyle ToolbarButtonFlat_Scene => Get(ToolbarButtonFlat, EditorSkin.Scene);
        public const string toolbarbuttonLeft = "toolbarbuttonLeft";
        public static GUIStyle toolbarbuttonLeft_Game => Get(toolbarbuttonLeft, EditorSkin.Game);
        public static GUIStyle toolbarbuttonLeft_Inspector => Get(toolbarbuttonLeft, EditorSkin.Inspector);
        public static GUIStyle toolbarbuttonLeft_Scene => Get(toolbarbuttonLeft, EditorSkin.Scene);
        public const string toolbarbuttonRight = "toolbarbuttonRight";
        public static GUIStyle toolbarbuttonRight_Game => Get(toolbarbuttonRight, EditorSkin.Game);
        public static GUIStyle toolbarbuttonRight_Inspector => Get(toolbarbuttonRight, EditorSkin.Inspector);
        public static GUIStyle toolbarbuttonRight_Scene => Get(toolbarbuttonRight, EditorSkin.Scene);
        public const string ToolbarCreateAddNewDropDown = "ToolbarCreateAddNewDropDown";
        public static GUIStyle ToolbarCreateAddNewDropDown_Game => Get(ToolbarCreateAddNewDropDown, EditorSkin.Game);

        public static GUIStyle ToolbarCreateAddNewDropDown_Inspector =>
            Get(ToolbarCreateAddNewDropDown, EditorSkin.Inspector);

        public static GUIStyle ToolbarCreateAddNewDropDown_Scene => Get(ToolbarCreateAddNewDropDown, EditorSkin.Scene);
        public const string ToolbarDropDown = "ToolbarDropDown";
        public static GUIStyle ToolbarDropDown_Game => Get(ToolbarDropDown, EditorSkin.Game);
        public static GUIStyle ToolbarDropDown_Inspector => Get(ToolbarDropDown, EditorSkin.Inspector);
        public static GUIStyle ToolbarDropDown_Scene => Get(ToolbarDropDown, EditorSkin.Scene);
        public const string ToolbarDropDownLeft = "ToolbarDropDownLeft";
        public static GUIStyle ToolbarDropDownLeft_Game => Get(ToolbarDropDownLeft, EditorSkin.Game);
        public static GUIStyle ToolbarDropDownLeft_Inspector => Get(ToolbarDropDownLeft, EditorSkin.Inspector);
        public static GUIStyle ToolbarDropDownLeft_Scene => Get(ToolbarDropDownLeft, EditorSkin.Scene);
        public const string ToolbarDropDownRight = "ToolbarDropDownRight";
        public static GUIStyle ToolbarDropDownRight_Game => Get(ToolbarDropDownRight, EditorSkin.Game);
        public static GUIStyle ToolbarDropDownRight_Inspector => Get(ToolbarDropDownRight, EditorSkin.Inspector);
        public static GUIStyle ToolbarDropDownRight_Scene => Get(ToolbarDropDownRight, EditorSkin.Scene);
        public const string ToolbarDropDownToggle = "ToolbarDropDownToggle";
        public static GUIStyle ToolbarDropDownToggle_Game => Get(ToolbarDropDownToggle, EditorSkin.Game);
        public static GUIStyle ToolbarDropDownToggle_Inspector => Get(ToolbarDropDownToggle, EditorSkin.Inspector);
        public static GUIStyle ToolbarDropDownToggle_Scene => Get(ToolbarDropDownToggle, EditorSkin.Scene);
        public const string ToolbarDropDownToggleRight = "ToolbarDropDownToggleRight";
        public static GUIStyle ToolbarDropDownToggleRight_Game => Get(ToolbarDropDownToggleRight, EditorSkin.Game);

        public static GUIStyle ToolbarDropDownToggleRight_Inspector =>
            Get(ToolbarDropDownToggleRight, EditorSkin.Inspector);

        public static GUIStyle ToolbarDropDownToggleRight_Scene => Get(ToolbarDropDownToggleRight, EditorSkin.Scene);
        public const string ToolbarLabel = "ToolbarLabel";
        public static GUIStyle ToolbarLabel_Game => Get(ToolbarLabel, EditorSkin.Game);
        public static GUIStyle ToolbarLabel_Inspector => Get(ToolbarLabel, EditorSkin.Inspector);
        public static GUIStyle ToolbarLabel_Scene => Get(ToolbarLabel, EditorSkin.Scene);
        public const string ToolbarPopup = "ToolbarPopup";
        public static GUIStyle ToolbarPopup_Game => Get(ToolbarPopup, EditorSkin.Game);
        public static GUIStyle ToolbarPopup_Inspector => Get(ToolbarPopup, EditorSkin.Inspector);
        public static GUIStyle ToolbarPopup_Scene => Get(ToolbarPopup, EditorSkin.Scene);
        public const string ToolbarPopupLeft = "ToolbarPopupLeft";
        public static GUIStyle ToolbarPopupLeft_Game => Get(ToolbarPopupLeft, EditorSkin.Game);
        public static GUIStyle ToolbarPopupLeft_Inspector => Get(ToolbarPopupLeft, EditorSkin.Inspector);
        public static GUIStyle ToolbarPopupLeft_Scene => Get(ToolbarPopupLeft, EditorSkin.Scene);
        public const string ToolbarPopupRight = "ToolbarPopupRight";
        public static GUIStyle ToolbarPopupRight_Game => Get(ToolbarPopupRight, EditorSkin.Game);
        public static GUIStyle ToolbarPopupRight_Inspector => Get(ToolbarPopupRight, EditorSkin.Inspector);
        public static GUIStyle ToolbarPopupRight_Scene => Get(ToolbarPopupRight, EditorSkin.Scene);
        public const string ToolbarSeachCancelButton = "ToolbarSeachCancelButton";
        public static GUIStyle ToolbarSeachCancelButton_Game => Get(ToolbarSeachCancelButton, EditorSkin.Game);

        public static GUIStyle ToolbarSeachCancelButton_Inspector =>
            Get(ToolbarSeachCancelButton, EditorSkin.Inspector);

        public static GUIStyle ToolbarSeachCancelButton_Scene => Get(ToolbarSeachCancelButton, EditorSkin.Scene);
        public const string ToolbarSeachCancelButtonEmpty = "ToolbarSeachCancelButtonEmpty";

        public static GUIStyle ToolbarSeachCancelButtonEmpty_Game =>
            Get(ToolbarSeachCancelButtonEmpty, EditorSkin.Game);

        public static GUIStyle ToolbarSeachCancelButtonEmpty_Inspector =>
            Get(ToolbarSeachCancelButtonEmpty, EditorSkin.Inspector);

        public static GUIStyle ToolbarSeachCancelButtonEmpty_Scene =>
            Get(ToolbarSeachCancelButtonEmpty, EditorSkin.Scene);

        public const string ToolbarSeachTextField = "ToolbarSeachTextField";
        public static GUIStyle ToolbarSeachTextField_Game => Get(ToolbarSeachTextField, EditorSkin.Game);
        public static GUIStyle ToolbarSeachTextField_Inspector => Get(ToolbarSeachTextField, EditorSkin.Inspector);
        public static GUIStyle ToolbarSeachTextField_Scene => Get(ToolbarSeachTextField, EditorSkin.Scene);
        public const string ToolbarSeachTextFieldPopup = "ToolbarSeachTextFieldPopup";
        public static GUIStyle ToolbarSeachTextFieldPopup_Game => Get(ToolbarSeachTextFieldPopup, EditorSkin.Game);

        public static GUIStyle ToolbarSeachTextFieldPopup_Inspector =>
            Get(ToolbarSeachTextFieldPopup, EditorSkin.Inspector);

        public static GUIStyle ToolbarSeachTextFieldPopup_Scene => Get(ToolbarSeachTextFieldPopup, EditorSkin.Scene);
        public const string ToolbarSearchField = "ToolbarSearchField";
        public static GUIStyle ToolbarSearchField_Game => Get(ToolbarSearchField, EditorSkin.Game);
        public static GUIStyle ToolbarSearchField_Inspector => Get(ToolbarSearchField, EditorSkin.Inspector);
        public static GUIStyle ToolbarSearchField_Scene => Get(ToolbarSearchField, EditorSkin.Scene);
        public const string ToolbarSlider = "ToolbarSlider";
        public static GUIStyle ToolbarSlider_Game => Get(ToolbarSlider, EditorSkin.Game);
        public static GUIStyle ToolbarSlider_Inspector => Get(ToolbarSlider, EditorSkin.Inspector);
        public static GUIStyle ToolbarSlider_Scene => Get(ToolbarSlider, EditorSkin.Scene);
        public const string ToolbarSliderTextField = "ToolbarSliderTextField";
        public static GUIStyle ToolbarSliderTextField_Game => Get(ToolbarSliderTextField, EditorSkin.Game);
        public static GUIStyle ToolbarSliderTextField_Inspector => Get(ToolbarSliderTextField, EditorSkin.Inspector);
        public static GUIStyle ToolbarSliderTextField_Scene => Get(ToolbarSliderTextField, EditorSkin.Scene);
        public const string ToolbarTextField = "ToolbarTextField";
        public static GUIStyle ToolbarTextField_Game => Get(ToolbarTextField, EditorSkin.Game);
        public static GUIStyle ToolbarTextField_Inspector => Get(ToolbarTextField, EditorSkin.Inspector);
        public static GUIStyle ToolbarTextField_Scene => Get(ToolbarTextField, EditorSkin.Scene);
        public const string Tooltip = "Tooltip";
        public static GUIStyle Tooltip_Game => Get(Tooltip, EditorSkin.Game);
        public static GUIStyle Tooltip_Inspector => Get(Tooltip, EditorSkin.Inspector);
        public static GUIStyle Tooltip_Scene => Get(Tooltip, EditorSkin.Scene);
        public const string TV_Insertion = "TV Insertion";
        public static GUIStyle TV_Insertion_Game => Get(TV_Insertion, EditorSkin.Game);
        public static GUIStyle TV_Insertion_Inspector => Get(TV_Insertion, EditorSkin.Inspector);
        public static GUIStyle TV_Insertion_Scene => Get(TV_Insertion, EditorSkin.Scene);
        public const string TV_Line = "TV Line";
        public static GUIStyle TV_Line_Game => Get(TV_Line, EditorSkin.Game);
        public static GUIStyle TV_Line_Inspector => Get(TV_Line, EditorSkin.Inspector);
        public static GUIStyle TV_Line_Scene => Get(TV_Line, EditorSkin.Scene);
        public const string TV_LineBold = "TV LineBold";
        public static GUIStyle TV_LineBold_Game => Get(TV_LineBold, EditorSkin.Game);
        public static GUIStyle TV_LineBold_Inspector => Get(TV_LineBold, EditorSkin.Inspector);
        public static GUIStyle TV_LineBold_Scene => Get(TV_LineBold, EditorSkin.Scene);
        public const string TV_Ping = "TV Ping";
        public static GUIStyle TV_Ping_Game => Get(TV_Ping, EditorSkin.Game);
        public static GUIStyle TV_Ping_Inspector => Get(TV_Ping, EditorSkin.Inspector);
        public static GUIStyle TV_Ping_Scene => Get(TV_Ping, EditorSkin.Scene);
        public const string TV_Selection = "TV Selection";
        public static GUIStyle TV_Selection_Game => Get(TV_Selection, EditorSkin.Game);
        public static GUIStyle TV_Selection_Inspector => Get(TV_Selection, EditorSkin.Inspector);
        public static GUIStyle TV_Selection_Scene => Get(TV_Selection, EditorSkin.Scene);
        public const string U2D_createRect = "U2D.createRect";
        public static GUIStyle U2D_createRect_Game => Get(U2D_createRect, EditorSkin.Game);
        public static GUIStyle U2D_createRect_Inspector => Get(U2D_createRect, EditorSkin.Inspector);
        public static GUIStyle U2D_createRect_Scene => Get(U2D_createRect, EditorSkin.Scene);
        public const string U2D_dragDot = "U2D.dragDot";
        public static GUIStyle U2D_dragDot_Game => Get(U2D_dragDot, EditorSkin.Game);
        public static GUIStyle U2D_dragDot_Inspector => Get(U2D_dragDot, EditorSkin.Inspector);
        public static GUIStyle U2D_dragDot_Scene => Get(U2D_dragDot, EditorSkin.Scene);
        public const string U2D_dragDotActive = "U2D.dragDotActive";
        public static GUIStyle U2D_dragDotActive_Game => Get(U2D_dragDotActive, EditorSkin.Game);
        public static GUIStyle U2D_dragDotActive_Inspector => Get(U2D_dragDotActive, EditorSkin.Inspector);
        public static GUIStyle U2D_dragDotActive_Scene => Get(U2D_dragDotActive, EditorSkin.Scene);
        public const string U2D_dragDotDimmed = "U2D.dragDotDimmed";
        public static GUIStyle U2D_dragDotDimmed_Game => Get(U2D_dragDotDimmed, EditorSkin.Game);
        public static GUIStyle U2D_dragDotDimmed_Inspector => Get(U2D_dragDotDimmed, EditorSkin.Inspector);
        public static GUIStyle U2D_dragDotDimmed_Scene => Get(U2D_dragDotDimmed, EditorSkin.Scene);
        public const string U2D_pivotDot = "U2D.pivotDot";
        public static GUIStyle U2D_pivotDot_Game => Get(U2D_pivotDot, EditorSkin.Game);
        public static GUIStyle U2D_pivotDot_Inspector => Get(U2D_pivotDot, EditorSkin.Inspector);
        public static GUIStyle U2D_pivotDot_Scene => Get(U2D_pivotDot, EditorSkin.Scene);
        public const string U2D_pivotDotActive = "U2D.pivotDotActive";
        public static GUIStyle U2D_pivotDotActive_Game => Get(U2D_pivotDotActive, EditorSkin.Game);
        public static GUIStyle U2D_pivotDotActive_Inspector => Get(U2D_pivotDotActive, EditorSkin.Inspector);
        public static GUIStyle U2D_pivotDotActive_Scene => Get(U2D_pivotDotActive, EditorSkin.Scene);
        public const string VerticalMinMaxScrollbarThumb = "VerticalMinMaxScrollbarThumb";
        public static GUIStyle VerticalMinMaxScrollbarThumb_Game => Get(VerticalMinMaxScrollbarThumb, EditorSkin.Game);

        public static GUIStyle VerticalMinMaxScrollbarThumb_Inspector =>
            Get(VerticalMinMaxScrollbarThumb, EditorSkin.Inspector);

        public static GUIStyle VerticalMinMaxScrollbarThumb_Scene =>
            Get(VerticalMinMaxScrollbarThumb, EditorSkin.Scene);

        public const string VerticalSliderThumbExtent = "VerticalSliderThumbExtent";
        public static GUIStyle VerticalSliderThumbExtent_Game => Get(VerticalSliderThumbExtent, EditorSkin.Game);

        public static GUIStyle VerticalSliderThumbExtent_Inspector =>
            Get(VerticalSliderThumbExtent, EditorSkin.Inspector);

        public static GUIStyle VerticalSliderThumbExtent_Scene => Get(VerticalSliderThumbExtent, EditorSkin.Scene);
        public const string VideoClipImporterLabel = "VideoClipImporterLabel";
        public static GUIStyle VideoClipImporterLabel_Game => Get(VideoClipImporterLabel, EditorSkin.Game);
        public static GUIStyle VideoClipImporterLabel_Inspector => Get(VideoClipImporterLabel, EditorSkin.Inspector);
        public static GUIStyle VideoClipImporterLabel_Scene => Get(VideoClipImporterLabel, EditorSkin.Scene);
        public const string WarningOverlay = "WarningOverlay";
        public static GUIStyle WarningOverlay_Game => Get(WarningOverlay, EditorSkin.Game);
        public static GUIStyle WarningOverlay_Inspector => Get(WarningOverlay, EditorSkin.Inspector);
        public static GUIStyle WarningOverlay_Scene => Get(WarningOverlay, EditorSkin.Scene);
        public const string WhiteBackground = "WhiteBackground";
        public static GUIStyle WhiteBackground_Game => Get(WhiteBackground, EditorSkin.Game);
        public static GUIStyle WhiteBackground_Inspector => Get(WhiteBackground, EditorSkin.Inspector);
        public static GUIStyle WhiteBackground_Scene => Get(WhiteBackground, EditorSkin.Scene);
        public const string WhiteBoldLabel = "WhiteBoldLabel";
        public static GUIStyle WhiteBoldLabel_Game => Get(WhiteBoldLabel, EditorSkin.Game);
        public static GUIStyle WhiteBoldLabel_Inspector => Get(WhiteBoldLabel, EditorSkin.Inspector);
        public static GUIStyle WhiteBoldLabel_Scene => Get(WhiteBoldLabel, EditorSkin.Scene);
        public const string WhiteLabel = "WhiteLabel";
        public static GUIStyle WhiteLabel_Game => Get(WhiteLabel, EditorSkin.Game);
        public static GUIStyle WhiteLabel_Inspector => Get(WhiteLabel, EditorSkin.Inspector);
        public static GUIStyle WhiteLabel_Scene => Get(WhiteLabel, EditorSkin.Scene);
        public const string WhiteLargeCenterLabel = "WhiteLargeCenterLabel";
        public static GUIStyle WhiteLargeCenterLabel_Game => Get(WhiteLargeCenterLabel, EditorSkin.Game);
        public static GUIStyle WhiteLargeCenterLabel_Inspector => Get(WhiteLargeCenterLabel, EditorSkin.Inspector);
        public static GUIStyle WhiteLargeCenterLabel_Scene => Get(WhiteLargeCenterLabel, EditorSkin.Scene);
        public const string WhiteLargeLabel = "WhiteLargeLabel";
        public static GUIStyle WhiteLargeLabel_Game => Get(WhiteLargeLabel, EditorSkin.Game);
        public static GUIStyle WhiteLargeLabel_Inspector => Get(WhiteLargeLabel, EditorSkin.Inspector);
        public static GUIStyle WhiteLargeLabel_Scene => Get(WhiteLargeLabel, EditorSkin.Scene);
        public const string WhiteMiniLabel = "WhiteMiniLabel";
        public static GUIStyle WhiteMiniLabel_Game => Get(WhiteMiniLabel, EditorSkin.Game);
        public static GUIStyle WhiteMiniLabel_Inspector => Get(WhiteMiniLabel, EditorSkin.Inspector);
        public static GUIStyle WhiteMiniLabel_Scene => Get(WhiteMiniLabel, EditorSkin.Scene);
        public const string WinBtn = "WinBtn";
        public static GUIStyle WinBtn_Game => Get(WinBtn, EditorSkin.Game);
        public static GUIStyle WinBtn_Inspector => Get(WinBtn, EditorSkin.Inspector);
        public static GUIStyle WinBtn_Scene => Get(WinBtn, EditorSkin.Scene);
        public const string WinBtnClose = "WinBtnClose";
        public static GUIStyle WinBtnClose_Game => Get(WinBtnClose, EditorSkin.Game);
        public static GUIStyle WinBtnClose_Inspector => Get(WinBtnClose, EditorSkin.Inspector);
        public static GUIStyle WinBtnClose_Scene => Get(WinBtnClose, EditorSkin.Scene);
        public const string WinBtnCloseMac = "WinBtnCloseMac";
        public static GUIStyle WinBtnCloseMac_Game => Get(WinBtnCloseMac, EditorSkin.Game);
        public static GUIStyle WinBtnCloseMac_Inspector => Get(WinBtnCloseMac, EditorSkin.Inspector);
        public static GUIStyle WinBtnCloseMac_Scene => Get(WinBtnCloseMac, EditorSkin.Scene);
        public const string WinBtnInactiveMac = "WinBtnInactiveMac";
        public static GUIStyle WinBtnInactiveMac_Game => Get(WinBtnInactiveMac, EditorSkin.Game);
        public static GUIStyle WinBtnInactiveMac_Inspector => Get(WinBtnInactiveMac, EditorSkin.Inspector);
        public static GUIStyle WinBtnInactiveMac_Scene => Get(WinBtnInactiveMac, EditorSkin.Scene);
        public const string WinBtnMax = "WinBtnMax";
        public static GUIStyle WinBtnMax_Game => Get(WinBtnMax, EditorSkin.Game);
        public static GUIStyle WinBtnMax_Inspector => Get(WinBtnMax, EditorSkin.Inspector);
        public static GUIStyle WinBtnMax_Scene => Get(WinBtnMax, EditorSkin.Scene);
        public const string WinBtnMaxMac = "WinBtnMaxMac";
        public static GUIStyle WinBtnMaxMac_Game => Get(WinBtnMaxMac, EditorSkin.Game);
        public static GUIStyle WinBtnMaxMac_Inspector => Get(WinBtnMaxMac, EditorSkin.Inspector);
        public static GUIStyle WinBtnMaxMac_Scene => Get(WinBtnMaxMac, EditorSkin.Scene);
        public const string WinBtnMinMac = "WinBtnMinMac";
        public static GUIStyle WinBtnMinMac_Game => Get(WinBtnMinMac, EditorSkin.Game);
        public static GUIStyle WinBtnMinMac_Inspector => Get(WinBtnMinMac, EditorSkin.Inspector);
        public static GUIStyle WinBtnMinMac_Scene => Get(WinBtnMinMac, EditorSkin.Scene);
        public const string WinBtnRestore = "WinBtnRestore";
        public static GUIStyle WinBtnRestore_Game => Get(WinBtnRestore, EditorSkin.Game);
        public static GUIStyle WinBtnRestore_Inspector => Get(WinBtnRestore, EditorSkin.Inspector);
        public static GUIStyle WinBtnRestore_Scene => Get(WinBtnRestore, EditorSkin.Scene);
        public const string WinBtnRestoreMac = "WinBtnRestoreMac";
        public static GUIStyle WinBtnRestoreMac_Game => Get(WinBtnRestoreMac, EditorSkin.Game);
        public static GUIStyle WinBtnRestoreMac_Inspector => Get(WinBtnRestoreMac, EditorSkin.Inspector);
        public static GUIStyle WinBtnRestoreMac_Scene => Get(WinBtnRestoreMac, EditorSkin.Scene);
        public const string WindowBottomResize = "WindowBottomResize";
        public static GUIStyle WindowBottomResize_Game => Get(WindowBottomResize, EditorSkin.Game);
        public static GUIStyle WindowBottomResize_Inspector => Get(WindowBottomResize, EditorSkin.Inspector);
        public static GUIStyle WindowBottomResize_Scene => Get(WindowBottomResize, EditorSkin.Scene);
        public const string Wizard_Box = "Wizard Box";
        public static GUIStyle Wizard_Box_Game => Get(Wizard_Box, EditorSkin.Game);
        public static GUIStyle Wizard_Box_Inspector => Get(Wizard_Box, EditorSkin.Inspector);
        public static GUIStyle Wizard_Box_Scene => Get(Wizard_Box, EditorSkin.Scene);
        public const string Wizard_Error = "Wizard Error";
        public static GUIStyle Wizard_Error_Game => Get(Wizard_Error, EditorSkin.Game);
        public static GUIStyle Wizard_Error_Inspector => Get(Wizard_Error, EditorSkin.Inspector);
        public static GUIStyle Wizard_Error_Scene => Get(Wizard_Error, EditorSkin.Scene);
        public const string WordWrapLabel = "WordWrapLabel";
        public static GUIStyle WordWrapLabel_Game => Get(WordWrapLabel, EditorSkin.Game);
        public static GUIStyle WordWrapLabel_Inspector => Get(WordWrapLabel, EditorSkin.Inspector);
        public static GUIStyle WordWrapLabel_Scene => Get(WordWrapLabel, EditorSkin.Scene);
        public const string wordwrapminibutton = "wordwrapminibutton";
        public static GUIStyle wordwrapminibutton_Game => Get(wordwrapminibutton, EditorSkin.Game);
        public static GUIStyle wordwrapminibutton_Inspector => Get(wordwrapminibutton, EditorSkin.Inspector);
        public static GUIStyle wordwrapminibutton_Scene => Get(wordwrapminibutton, EditorSkin.Scene);
        public const string WordWrappedLabel = "WordWrappedLabel";
        public static GUIStyle WordWrappedLabel_Game => Get(WordWrappedLabel, EditorSkin.Game);
        public static GUIStyle WordWrappedLabel_Inspector => Get(WordWrappedLabel, EditorSkin.Inspector);
        public static GUIStyle WordWrappedLabel_Scene => Get(WordWrappedLabel, EditorSkin.Scene);
        public const string WordWrappedMiniLabel = "WordWrappedMiniLabel";
        public static GUIStyle WordWrappedMiniLabel_Game => Get(WordWrappedMiniLabel, EditorSkin.Game);
        public static GUIStyle WordWrappedMiniLabel_Inspector => Get(WordWrappedMiniLabel, EditorSkin.Inspector);
        public static GUIStyle WordWrappedMiniLabel_Scene => Get(WordWrappedMiniLabel, EditorSkin.Scene);
    }
}
#endif