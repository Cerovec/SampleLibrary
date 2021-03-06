//
//  PPScanner.m
//  PPScanner
//
//  Created by Jura on 16/02/16.
//  Copyright © 2016 MicroBlink. All rights reserved.
//

#import "PPScanner.h"
#import "PPViewController.h"
#import "PPScannerController.h"

@interface PPScanner ()

@property (nonatomic, strong) id<PPScannerDelegate> delegate;

@end

@implementation PPScanner

- (instancetype)init {
    self = [super init];
    if (self) {

    }
    return self;
}

- (UIViewController<PPScannerController> *)controller {
    return [[PPViewController alloc] init];
}

- (void)setDelegate:(id<PPScannerDelegate>)delegate {
    _delegate = delegate;
}

- (void)run {
    if ([self.delegate respondsToSelector:@selector(didStart)]) {
        [self.delegate didStart];
    }

    if ([self.delegate respondsToSelector:@selector(didFinish)]) {
        [self.delegate didFinish];
    }
}

@end
