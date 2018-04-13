﻿using System;

using ObjCRuntime;
using Foundation;
using UIKit;

//using AccountKit;

namespace Facebook.AccountKit
{
    // @protocol AKFAccessToken <NSObject, NSCopying, NSSecureCoding>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AccessToken : INSCopying, INSSecureCoding
    {
        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull accountID;
        [Abstract]
        [Export("accountID")]
        string AccountID { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull applicationID;
        [Abstract]
        [Export("applicationID")]
        string ApplicationID { get; }

        // @required @property (readonly, copy, nonatomic) NSDate * _Nonnull lastRefresh;
        [Abstract]
        [Export("lastRefresh", ArgumentSemantic.Copy)]
        NSDate LastRefresh { get; }

        // @required @property (readonly, assign, nonatomic) NSTimeInterval tokenRefreshInterval;
        [Abstract]
        [Export("tokenRefreshInterval")]
        double TokenRefreshInterval { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull tokenString;
        [Abstract]
        [Export("tokenString")]
        string TokenString { get; }
    }

    // @protocol AKFAccount <NSObject, NSCopying, NSSecureCoding>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface Account : INSCopying, INSSecureCoding
    {
        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull accountID;
        [Abstract]
        [Export("accountID")]
        string AccountID { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable emailAddress;
        [Abstract]
        [NullAllowed, Export("emailAddress")]
        string EmailAddress { get; }

        // @required @property (readonly, copy, nonatomic) AKFPhoneNumber * _Nullable phoneNumber;
        [Abstract]
        [NullAllowed, Export("phoneNumber", ArgumentSemantic.Copy)]
        PhoneNumber PhoneNumber { get; }
    }

    // @protocol AKFConfiguring
    [Protocol]
    interface Configuring
    {
        // @required @property (copy, nonatomic) NSArray<NSString *> * blacklistedCountryCodes;
        [Abstract]
        [Export("blacklistedCountryCodes", ArgumentSemantic.Copy)]
        string[] BlacklistedCountryCodes { get; set; }

        // @required @property (copy, nonatomic) NSString * defaultCountryCode;
        [Abstract]
        [Export("defaultCountryCode")]
        string DefaultCountryCode { get; set; }

        // @required @property (assign, nonatomic) BOOL enableSendToFacebook;
        [Abstract]
        [Export("enableSendToFacebook")]
        bool EnableSendToFacebook { get; set; }

        // @required @property (assign, nonatomic) BOOL enableGetACall;
        [Abstract]
        [Export("enableGetACall")]
        bool EnableGetACall { get; set; }

        // @required @property (copy, nonatomic) NSArray<NSString *> * whitelistedCountryCodes;
        [Abstract]
        [Export("whitelistedCountryCodes", ArgumentSemantic.Copy)]
        string[] WhitelistedCountryCodes { get; set; }
    }

    // @interface Theme : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface Theme : INSCopying
    {
        [Field("AKFButtonTypeCount", "__Internal")]
        nuint ButtonTypeCount { get; }

        [Field("AKFLoginFlowStateCount", "__Internal")]
        nuint LoginFlowStateCount { get; }

        [Field("AKFTextPositionCount", "__Internal")]
        nuint TextPositionCount { get; }

        [Field("AKFHeaderTextTypeCount", "__Internal")]
        nuint HeaderTextTypeCount { get; }

        // +(instancetype _Nonnull)defaultTheme;
        [Static]
        [Export("defaultTheme")]
        Theme DefaultTheme();

        // +(instancetype _Nonnull)outlineTheme;
        [Static]
        [Export("outlineTheme")]
        Theme OutlineTheme();

        // +(instancetype _Nonnull)outlineThemeWithPrimaryColor:(UIColor * _Nonnull)primaryColor primaryTextColor:(UIColor * _Nonnull)primaryTextColor secondaryTextColor:(UIColor * _Nonnull)secondaryTextColor statusBarStyle:(UIStatusBarStyle)statusBarStyle;
        [Static]
        [Export("outlineThemeWithPrimaryColor:primaryTextColor:secondaryTextColor:statusBarStyle:")]
        Theme OutlineThemeWithPrimaryColor(UIColor primaryColor, UIColor primaryTextColor, UIColor secondaryTextColor, UIStatusBarStyle statusBarStyle);

        // +(instancetype _Nonnull)themeWithPrimaryColor:(UIColor * _Nonnull)primaryColor primaryTextColor:(UIColor * _Nonnull)primaryTextColor secondaryColor:(UIColor * _Nonnull)secondaryColor secondaryTextColor:(UIColor * _Nonnull)secondaryTextColor statusBarStyle:(UIStatusBarStyle)statusBarStyle;
        [Static]
        [Export("themeWithPrimaryColor:primaryTextColor:secondaryColor:secondaryTextColor:statusBarStyle:")]
        Theme ThemeWithPrimaryColor(UIColor primaryColor, UIColor primaryTextColor, UIColor secondaryColor, UIColor secondaryTextColor, UIStatusBarStyle statusBarStyle);

        // @property (copy, nonatomic) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Copy)]
        UIColor BackgroundColor { get; set; }

        // @property (copy, nonatomic) UIImage * _Nullable backgroundImage;
        [NullAllowed, Export("backgroundImage", ArgumentSemantic.Copy)]
        UIImage BackgroundImage { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull buttonBackgroundColor;
        [Export("buttonBackgroundColor", ArgumentSemantic.Copy)]
        UIColor ButtonBackgroundColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull buttonBorderColor;
        [Export("buttonBorderColor", ArgumentSemantic.Copy)]
        UIColor ButtonBorderColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull buttonDisabledBackgroundColor;
        [Export("buttonDisabledBackgroundColor", ArgumentSemantic.Copy)]
        UIColor ButtonDisabledBackgroundColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull buttonDisabledBorderColor;
        [Export("buttonDisabledBorderColor", ArgumentSemantic.Copy)]
        UIColor ButtonDisabledBorderColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull buttonDisabledTextColor;
        [Export("buttonDisabledTextColor", ArgumentSemantic.Copy)]
        UIColor ButtonDisabledTextColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull buttonHighlightedBackgroundColor;
        [Export("buttonHighlightedBackgroundColor", ArgumentSemantic.Copy)]
        UIColor ButtonHighlightedBackgroundColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull buttonHighlightedBorderColor;
        [Export("buttonHighlightedBorderColor", ArgumentSemantic.Copy)]
        UIColor ButtonHighlightedBorderColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull buttonHighlightedTextColor;
        [Export("buttonHighlightedTextColor", ArgumentSemantic.Copy)]
        UIColor ButtonHighlightedTextColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull buttonTextColor;
        [Export("buttonTextColor", ArgumentSemantic.Copy)]
        UIColor ButtonTextColor { get; set; }

        // @property (assign, nonatomic) AKFButtonTranslucentStyle buttonTranslucenStyle;
        [Export("buttonTranslucenStyle", ArgumentSemantic.Assign)]
        ButtonTranslucentStyle ButtonTranslucenStyle { get; set; }

        // @property (assign, nonatomic) NSUInteger contentBodyLayoutWeight;
        [Export("contentBodyLayoutWeight")]
        nuint ContentBodyLayoutWeight { get; set; }

        // @property (assign, nonatomic) NSUInteger contentBottomLayoutWeight;
        [Export("contentBottomLayoutWeight")]
        nuint ContentBottomLayoutWeight { get; set; }

        // @property (assign, nonatomic) NSUInteger contentFooterLayoutWeight;
        [Export("contentFooterLayoutWeight")]
        nuint ContentFooterLayoutWeight { get; set; }

        // @property (assign, nonatomic) NSUInteger contentHeaderLayoutWeight;
        [Export("contentHeaderLayoutWeight")]
        nuint ContentHeaderLayoutWeight { get; set; }

        // @property (assign, nonatomic) CGFloat contentMarginLeft;
        [Export("contentMarginLeft")]
        nfloat ContentMarginLeft { get; set; }

        // @property (assign, nonatomic) CGFloat contentMarginRight;
        [Export("contentMarginRight")]
        nfloat ContentMarginRight { get; set; }

        // @property (assign, nonatomic) CGFloat contentMaxWidth;
        [Export("contentMaxWidth")]
        nfloat ContentMaxWidth { get; set; }

        // @property (assign, nonatomic) CGFloat contentMinHeight;
        [Export("contentMinHeight")]
        nfloat ContentMinHeight { get; set; }

        // @property (assign, nonatomic) NSUInteger contentTextLayoutWeight;
        [Export("contentTextLayoutWeight")]
        nuint ContentTextLayoutWeight { get; set; }

        // @property (assign, nonatomic) NSUInteger contentTopLayoutWeight;
        [Export("contentTopLayoutWeight")]
        nuint ContentTopLayoutWeight { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull headerBackgroundColor;
        [Export("headerBackgroundColor", ArgumentSemantic.Copy)]
        UIColor HeaderBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull headerButtonTextColor;
        [Export("headerButtonTextColor", ArgumentSemantic.Strong)]
        UIColor HeaderButtonTextColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull headerTextColor;
        [Export("headerTextColor", ArgumentSemantic.Copy)]
        UIColor HeaderTextColor { get; set; }

        // @property (assign, nonatomic) AKFHeaderTextType headerTextType;
        [Export("headerTextType", ArgumentSemantic.Assign)]
        HeaderTextType HeaderTextType { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull iconColor;
        [Export("iconColor", ArgumentSemantic.Copy)]
        UIColor IconColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull inputBackgroundColor;
        [Export("inputBackgroundColor", ArgumentSemantic.Copy)]
        UIColor InputBackgroundColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull inputBorderColor;
        [Export("inputBorderColor", ArgumentSemantic.Copy)]
        UIColor InputBorderColor { get; set; }

        // @property (assign, nonatomic) AKFInputStyle inputStyle;
        [Export("inputStyle", ArgumentSemantic.Assign)]
        InputStyle InputStyle { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull inputTextColor;
        [Export("inputTextColor", ArgumentSemantic.Copy)]
        UIColor InputTextColor { get; set; }

        // @property (assign, nonatomic) UIStatusBarStyle statusBarStyle;
        [Export("statusBarStyle", ArgumentSemantic.Assign)]
        UIStatusBarStyle StatusBarStyle { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull textColor;
        [Export("textColor", ArgumentSemantic.Copy)]
        UIColor TextColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull titleColor;
        [Export("titleColor", ArgumentSemantic.Copy)]
        UIColor TitleColor { get; set; }

        // -(BOOL)isEqualToTheme:(Theme * _Nonnull)theme;
        [Export("isEqualToTheme:")]
        bool IsEqualToTheme(Theme theme);
    }

    // @protocol AKFActionController <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ActionController
    {
        // @required -(void)back;
        [Abstract]
        [Export("back")]
        void Back();

        // @required -(void)cancel;
        [Abstract]
        [Export("cancel")]
        void Cancel();
    }

    // @protocol AKFUIManager <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UIManager
    {
        // @optional -(UIView * _Nullable)actionBarViewForState:(AKFLoginFlowState)state;
        [Export("actionBarViewForState:")]
        [return: NullAllowed]
        UIView ActionBarViewForState(LoginFlowState state);

        // @optional -(UIView * _Nullable)bodyViewForState:(AKFLoginFlowState)state;
        [Export("bodyViewForState:")]
        [return: NullAllowed]
        UIView BodyViewForState(LoginFlowState state);

        // @optional -(AKFButtonType)buttonTypeForState:(AKFLoginFlowState)state;
        [Export("buttonTypeForState:")]
        ButtonType ButtonTypeForState(LoginFlowState state);

        // @optional -(UIView * _Nullable)footerViewForState:(AKFLoginFlowState)state;
        [Export("footerViewForState:")]
        [return: NullAllowed]
        UIView FooterViewForState(LoginFlowState state);

        // @optional -(UIView * _Nullable)headerViewForState:(AKFLoginFlowState)state;
        [Export("headerViewForState:")]
        [return: NullAllowed]
        UIView HeaderViewForState(LoginFlowState state);

        // @optional -(void)setActionController:(id<AKFActionController> _Nonnull)actionController;
        [Export("setActionController:")]
        void SetActionController(ActionController actionController);

        // @optional -(void)setError:(NSError * _Nonnull)error;
        [Export("setError:")]
        void SetError(NSError error);

        // @optional -(AKFTextPosition)textPositionForState:(AKFLoginFlowState)state;
        [Export("textPositionForState:")]
        TextPosition TextPositionForState(LoginFlowState state);

        // @optional -(Theme * _Nullable)theme;
        [NullAllowed, Export("theme")]
        //[Verify(MethodToProperty)]
        Theme Theme { get; }
    }

    // @protocol AKFAdvancedUIManager <AKFUIManager>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AdvancedUIManager : UIManager
    {
    }

    // @protocol AKFAdvancedUIActionController <AKFActionController>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AdvancedUIActionController : ActionController
    {
    }

    // @protocol AKFUIManaging <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UIManaging
    {
        // @required @property (nonatomic, strong) id<AKFUIManager> uiManager;
        [Abstract]
        [Export("uiManager", ArgumentSemantic.Strong)]
        UIManager UiManager { get; set; }

        // @required -(void)setAdvancedUIManager:(id<AKFAdvancedUIManager>)uiManager;
        [Abstract]
        [Export("setAdvancedUIManager:")]
        void SetAdvancedUIManager(AdvancedUIManager uiManager);

        // @required -(void)setTheme:(Theme *)theme;
        [Abstract]
        [Export("setTheme:")]
        void SetTheme(Theme theme);
    }

    // @protocol AKFViewController <AKFUIManaging, AKFConfiguring>
    //[Protocol, Model]
    [Model]
    [BaseType(typeof(NSObject))]
    interface ViewController : UIManaging, Configuring
    {
        //[Abstract]
        [Wrap("WeakDelegate")]
        ViewControllerDelegate Delegate { get; set; }

        // @required @property (nonatomic, weak) id<AKFViewControllerDelegate> delegate;
        //[Abstract]
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @required @property (readonly, assign, nonatomic) AKFLoginType loginType;
        //[Abstract]
        [Export("loginType", ArgumentSemantic.Assign)]
        LoginType LoginType { get; }
    }

    // @protocol AKFViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ViewControllerDelegate
    {
        // @optional -(void)viewController:(UIViewController<AKFViewController> *)viewController didCompleteLoginWithAuthorizationCode:(NSString *)code state:(NSString *)state;
        [Export("viewController:didCompleteLoginWithAuthorizationCode:state:")]
        void ViewController(ViewController viewController, string code, string state);

        // @optional -(void)viewController:(UIViewController<AKFViewController> *)viewController didCompleteLoginWithAccessToken:(id<AKFAccessToken>)accessToken state:(NSString *)state;
        [Export("viewController:didCompleteLoginWithAccessToken:state:")]
        void ViewController(ViewController viewController, AccessToken accessToken, string state);

        // @optional -(void)viewController:(UIViewController<AKFViewController> *)viewController didFailWithError:(NSError *)error;
        [Export("viewController:didFailWithError:")]
        void ViewController(ViewController viewController, NSError error);

        // @optional -(void)viewControllerDidCancel:(UIViewController<AKFViewController> *)viewController;
        [Export("viewControllerDidCancel:")]
        void ViewControllerDidCancel(ViewController viewController);
    }

    // typedef void (^AKFRequestAccountHandler)(id<AKFAccount> _Nullable, NSError * _Nullable);
    delegate void RequestAccountHandler([NullAllowed] Account arg0, [NullAllowed] NSError arg1);

    // typedef void (^AKFLogoutHandler)(BOOL, NSError * _Nullable);
    delegate void LogoutHandler(bool arg0, [NullAllowed] NSError arg1);

    // @interface AKFAccountKit : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AccountKit
    {
        [Field("AKFErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }

        [Field("AKFErrorDeveloperMessageKey", "__Internal")]
        NSString ErrorDeveloperMessageKey { get; }

        [Field("AKFErrorUserMessageKey", "__Internal")]
        NSString ErrorUserMessageKey { get; }

        [Field("AKFErrorObjectKey", "__Internal")]
        NSString ErrorObjectKey { get; }

        [Field("AKFServerErrorDomain", "__Internal")]
        NSString ServerErrorDomain { get; }

        // +(NSString * _Nonnull)graphVersionString;
        [Static]
        [Export("graphVersionString")]
        //[Verify(MethodToProperty)]
        string GraphVersionString { get; }

        // +(NSString * _Nonnull)versionString;
        [Static]
        [Export("versionString")]
        //[Verify(MethodToProperty)]
        string VersionString { get; }

        // @property (readonly, copy, nonatomic) id<AKFAccessToken> _Nullable currentAccessToken;
        [NullAllowed, Export("currentAccessToken", ArgumentSemantic.Copy)]
        AccessToken CurrentAccessToken { get; }

        // -(instancetype _Nonnull)initWithResponseType:(AKFResponseType)responseType __attribute__((objc_designated_initializer));
        [Export("initWithResponseType:")]
        [DesignatedInitializer]
        IntPtr Constructor(ResponseType responseType);

        // -(void)cancelLogin;
        [Export("cancelLogin")]
        void CancelLogin();

        // -(void)logOut;
        [Export("logOut")]
        void LogOut();

        // -(void)logOut:(AKFLogoutHandler _Nullable)handler;
        [Export("logOut:")]
        void LogOut([NullAllowed] LogoutHandler handler);

        // -(void)requestAccount:(AKFRequestAccountHandler _Nonnull)handler;
        [Export("requestAccount:")]
        void RequestAccount(RequestAccountHandler handler);

        // -(UIViewController<AKFViewController> * _Nonnull)viewControllerForEmailLogin;
        [Export("viewControllerForEmailLogin")]
        //[Verify(MethodToProperty)]
        //ViewController ViewControllerForEmailLogin { get; }
        ViewController ViewControllerForEmailLogin ();

        // -(UIViewController<AKFViewController> * _Nonnull)viewControllerForEmailLoginWithEmail:(NSString * _Nullable)email state:(NSString * _Nullable)state;
        [Export("viewControllerForEmailLoginWithEmail:state:")]
        ViewController ViewControllerForEmailLoginWithEmail([NullAllowed] string email, [NullAllowed] string state);

        // -(UIViewController<AKFViewController> * _Nonnull)viewControllerForPhoneLogin;
        [Export("viewControllerForPhoneLogin")]
        //[Verify(MethodToProperty)]
        //ViewController ViewControllerForPhoneLogin { get; }
        ViewController ViewControllerForPhoneLogin ();

        // -(UIViewController<AKFViewController> * _Nonnull)viewControllerForPhoneLoginWithPhoneNumber:(AKFPhoneNumber * _Nullable)phoneNumber state:(NSString * _Nullable)state;
        [Export("viewControllerForPhoneLoginWithPhoneNumber:state:")]
        ViewController ViewControllerForPhoneLoginWithPhoneNumber([NullAllowed] PhoneNumber phoneNumber, [NullAllowed] string state);

        // -(UIViewController<AKFViewController> * _Nullable)viewControllerForLoginResume;
        [NullAllowed, Export("viewControllerForLoginResume")]
        //[Verify(MethodToProperty)]
        //ViewController ViewControllerForLoginResume { get; }
        ViewController ViewControllerForLoginResume ();
    }

    // @interface AKFPhoneNumber : NSObject <NSCopying, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface PhoneNumber : INSCopying, INSSecureCoding
    {
        // -(instancetype _Nonnull)initWithCountryCode:(NSString * _Nonnull)countryCode phoneNumber:(NSString * _Nonnull)phoneNumber __attribute__((objc_designated_initializer));
        [Export("initWithCountryCode:phoneNumber:")]
        [DesignatedInitializer]
        IntPtr Constructor(string countryCode, string phoneNumber);

        // -(instancetype _Nonnull)initWithCountryCode:(NSString * _Nonnull)countryCode countryISO:(NSString * _Nonnull)iso phoneNumber:(NSString * _Nonnull)phoneNumber;
        [Export("initWithCountryCode:countryISO:phoneNumber:")]
        IntPtr Constructor(string countryCode, string iso, string phoneNumber);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull countryCode;
        [Export("countryCode")]
        string CountryCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull countryISO;
        [Export("countryISO")]
        string CountryISO { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull phoneNumber;
        [Export("phoneNumber")]
        string PhoneNumberString { get; }

        // -(BOOL)isEqualToPhoneNumber:(AKFPhoneNumber * _Nonnull)phoneNumber;
        [Export("isEqualToPhoneNumber:")]
        bool IsEqualToPhoneNumber(PhoneNumber phoneNumber);

        // -(NSString * _Nonnull)stringRepresentation;
        [Export("stringRepresentation")]
        //[Verify(MethodToProperty)]
        //string StringRepresentation { get; }
        string StringRepresentation ();
    }

    // @interface AKFSettings : NSObject
    [BaseType(typeof(NSObject))]
    interface Settings
    {
        // +(NSString * _Nonnull)clientToken;
        // +(void)setClientToken:(NSString * _Nonnull)clientToken;
        [Static]
        [Export("clientToken")]
        //[Verify(MethodToProperty)]
        string ClientToken { get; set; }
    }

    // @interface AKFSkinManager : NSObject <AKFUIManager>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SkinManager : UIManager
    {
        // -(instancetype _Nonnull)initWithSkinType:(AKFSkinType)skinType primaryColor:(UIColor * _Nullable)primaryColor backgroundImage:(UIImage * _Nullable)backgroundImage backgroundTint:(AKFBackgroundTint)backgroundTint tintIntensity:(CGFloat)tintIntensity __attribute__((objc_designated_initializer));
        [Export("initWithSkinType:primaryColor:backgroundImage:backgroundTint:tintIntensity:")]
        [DesignatedInitializer]
        IntPtr Constructor(SkinType skinType, [NullAllowed] UIColor primaryColor, [NullAllowed] UIImage backgroundImage, BackgroundTint backgroundTint, nfloat tintIntensity);

        // -(instancetype _Nonnull)initWithSkinType:(AKFSkinType)skinType primaryColor:(UIColor * _Nullable)primaryColor;
        [Export("initWithSkinType:primaryColor:")]
        IntPtr Constructor(SkinType skinType, [NullAllowed] UIColor primaryColor);

        // -(instancetype _Nonnull)initWithSkinType:(AKFSkinType)skinType;
        [Export("initWithSkinType:")]
        IntPtr Constructor(SkinType skinType);

        // @property (readonly, assign, nonatomic) AKFSkinType skinType;
        [Export("skinType", ArgumentSemantic.Assign)]
        SkinType SkinType { get; }

        // @property (readonly, copy, nonatomic) UIColor * _Null_unspecified primaryColor;
        [Export("primaryColor", ArgumentSemantic.Copy)]
        UIColor PrimaryColor { get; }

        // @property (readonly, copy, nonatomic) UIImage * _Nullable backgroundImage;
        [NullAllowed, Export("backgroundImage", ArgumentSemantic.Copy)]
        UIImage BackgroundImage { get; }

        // @property (readonly, assign, nonatomic) AKFBackgroundTint backgroundTint;
        [Export("backgroundTint", ArgumentSemantic.Assign)]
        BackgroundTint BackgroundTint { get; }

        // @property (readonly, assign, nonatomic) CGFloat tintIntensity;
        [Export("tintIntensity")]
        nfloat TintIntensity { get; }
    }
}

