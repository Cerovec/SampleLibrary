//
//  ViewController.m
//  PPScannerApp
//
//  Created by Jura on 16/02/16.
//  Copyright © 2016 MicroBlink. All rights reserved.
//

#import "ViewController.h"

#import <PPScanner/PPScannerFramework.h>

@interface ViewController () <PPScannerDelegate>

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (void)viewDidAppear:(BOOL)animated {
    PPScanner *scanner = [[PPScanner alloc] init];

    [scanner setDelegate:self];

    [scanner run];
}

- (void)didFinish {
    NSLog(@"Did finish");
}

- (void)didStart {
    NSLog(@"Did start");
}

@end
