//
//  PPScanner.h
//  PPScanner
//
//  Created by Jura on 16/02/16.
//  Copyright © 2016 MicroBlink. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "PPScannerDelegate.h"

@interface PPScanner : NSObject

- (instancetype)init;

- (void)setDelegate:(id<PPScannerDelegate>)delegate;

- (void)run;

@end
