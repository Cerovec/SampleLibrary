//
//  PPScannerDelegate.h
//  PPScanner
//
//  Created by Jura on 16/02/16.
//  Copyright © 2016 MicroBlink. All rights reserved.
//

#import <Foundation/Foundation.h>

@protocol PPScannerDelegate <NSObject>

@required

- (void)didFinish;

@optional

- (void)didStart;

@end
