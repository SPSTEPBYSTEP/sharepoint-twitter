﻿/*
 ===========================================================================
 Copyright (c) 2010 BrickRed Technologies Limited

 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sub-license, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.
 ===========================================================================
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace BrickRed.Webparts.Twitter
{
    class StyleSheet
    {
        public static Literal CssStyle()
        {
            Literal cssTextCntrl = new Literal();
            
            #region CSS
            cssTextCntrl.Text = "<style type=\"text/css\" rel=\"stylesheet\">" +
                                    @".ms-wpContentDivSpace
                                        {
                                            margin: 0px !important;
                                            padding:1px;
                                        }
                                      .alignCenter
                                        {
                                            text-align:center !important;
                                        }
                                      .twitHeaderImage
                                        {
                                            padding-left: 10px !important; 
                                            padding-right: 2px !important; 
                                            padding-top: 1px !important;
                                            padding-bottom: 1px !important;
                                            color: #02537b;
                                        }
                                      .twitBorderBottom
                                        {
                                            border-width: 0px 0px 1px 0px !important;
                                        }
                                      .twitHeaderText
                                        {
                                           font-size:15px !important;
                                           color:#02537b;
                                           text-decoration:none;
                                           padding-left:10px;
                                           vertical-align:middle;
                                           text-align:left;
                                           font-family :verdana,arial,helvetica,sans-serif !important;
                                        }
                                      .twitHeaderText a ,.twitHeaderText a:link,.twitHeaderText a:Active,.twitHeaderText a:Hover,.twitHeaderText a:visited
                                         {
                                           color :#02537b;
                                           font-size:15px !important;
                                           text-decoration :none !important;
                                           font-family :verdana,arial,helvetica,sans-serif !important;
                                         }
                                      .padding-align-right
                                        {
                                            padding-right:10px;
                                            text-align:right;
                                        }                                      
                                      .twitDisplayCount
                                        {
                                            padding:4px 2px 4px 10px !important;
                                        }
                                      .twitFooterBorder
                                        {
                                            background: none repeat scroll 0 0 #8EC1DA;
                                            color: #FFFFFF;
                                            cursor: default;
                                            padding-bottom: 5px;
                                            padding-top: 7px;
                                            padding-left: 7px;
                                        }
                                      .twitHeaderBorder
                                        {
                                            background-image:url('/_layouts/Brickred.OpenSource.Twitter/bg.png') !important ;
                                            background-repeat:repeat-x;
                                            color: #FFFFFF;
                                            cursor: default;
                                            padding-bottom: 3px;
                                            padding-top: 3px;
                                        }
                                      .txtboxTweetWrapper{border:1px solid #b7d9ed;overflow:hidden;height:auto;}
                                      .txtboxTweetWrapper textarea{border:none;width:100%;}
                                      .tweetCountButton
                                        {
                                            background-image:url('/_layouts/Images/BrickRed/TweetCount.png') !important ;
                                            background-repeat:no-repeat;
                                            width:50px !important;
                                            valign:middle !important;
                                            padding:5px 5px 5px 38px;
                                        }
                                </style>";
            #endregion

            return cssTextCntrl;
        }
    }
}
