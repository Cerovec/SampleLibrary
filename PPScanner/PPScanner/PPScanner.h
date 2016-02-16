//
//  PPScanner.h
//  PPScanner
//
//  Created by Jura on 16/02/16.
//  Copyright © 2016 MicroBlink. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import "PPScannerDelegate.h"

@protocol PPScannerController;

@interface PPScanner : NSObject

- (instancetype)init;

- (UIViewController<PPScannerController>*)controllerWithDelegate:(id<PPScannerDelegate>)delegate;

- (void)run;

@end
