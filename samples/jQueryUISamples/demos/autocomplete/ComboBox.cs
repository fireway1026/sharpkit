﻿using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.autocomplete
{
    [JsType(JsMode.Prototype)]
    public class ComboBox
    {
        //TODO: jQuery.widget
        static ComboBox()
        {
            //$.widget("ui.combobox", new jQueryUISamples.demos.autocomplete());
        }

        static void OnReady() 
        {
          
    //    {(function( $ ) {
    //    $.widget( "ui.combobox", {
    //        _create: function() {
    //            var input,
    //                self = this,
    //                select = this.element.hide(),
    //                selected = select.children( ":selected" ),
    //                value = selected.val() ? selected.text() : "",
    //                wrapper = this.wrapper = $( "<span>" )
    //                    .addClass( "ui-combobox" )
    //                    .insertAfter( select );

    //            input = $( "<input>" )
    //                .appendTo( wrapper )
    //                .val( value )
    //                .addClass( "ui-state-default ui-combobox-input" )
    //                .autocomplete({
    //                    delay: 0,
    //                    minLength: 0,
    //                    source: function( request, response ) {
    //                        var matcher = new RegExp( $.ui.autocomplete.escapeRegex(request.term), "i" );
    //                        response( select.children( "option" ).map(function() {
    //                            var text = $( this ).text();
    //                            if ( this.value && ( !request.term || matcher.test(text) ) )
    //                                return {
    //                                    label: text.replace(
    //                                        new RegExp(
    //                                            "(?![^&;]+;)(?!<[^<>]*)(" +
    //                                            $.ui.autocomplete.escapeRegex(request.term) +
    //                                            ")(?![^<>]*>)(?![^&;]+;)", "gi"
    //                                        ), "<strong>$1</strong>" ),
    //                                    value: text,
    //                                    option: this
    //                                };
    //                        }) );
    //                    },
    //                    select: function( event, ui ) {
    //                        ui.item.option.selected = true;
    //                        self._trigger( "selected", event, {
    //                            item: ui.item.option
    //                        });
    //                    },
    //                    change: function( event, ui ) {
    //                        if ( !ui.item ) {
    //                            var matcher = new RegExp( "^" + $.ui.autocomplete.escapeRegex( $(this).val() ) + "$", "i" ),
    //                                valid = false;
    //                            select.children( "option" ).each(function() {
    //                                if ( $( this ).text().match( matcher ) ) {
    //                                    this.selected = valid = true;
    //                                    return false;
    //                                }
    //                            });
    //                            if ( !valid ) {
    //                                // remove invalid value, as it didn't match anything
    //                                $( this ).val( "" );
    //                                select.val( "" );
    //                                input.data( "autocomplete" ).term = "";
    //                                return false;
    //                            }
    //                        }
    //                    }
    //                })
    //                .addClass( "ui-widget ui-widget-content ui-corner-left" );

    //            input.data( "autocomplete" )._renderItem = function( ul, item ) {
    //                return $( "<li></li>" )
    //                    .data( "item.autocomplete", item )
    //                    .append( "<a>" + item.label + "</a>" )
    //                    .appendTo( ul );
    //            };

    //            $( "<a>" )
    //                .attr( "tabIndex", -1 )
    //                .attr( "title", "Show All Items" )
    //                .appendTo( wrapper )
    //                .button({
    //                    icons: {
    //                        primary: "ui-icon-triangle-1-s"
    //                    },
    //                    text: false
    //                })
    //                .removeClass( "ui-corner-all" )
    //                .addClass( "ui-corner-right ui-combobox-toggle" )
    //                .click(function() {
    //                    // close if already visible
    //                    if ( input.autocomplete( "widget" ).is( ":visible" ) ) {
    //                        input.autocomplete( "close" );
    //                        return;
    //                    }

    //                    // work around a bug (likely same cause as #5265)
    //                    $( this ).blur();

    //                    // pass empty string as value to search for, displaying all results
    //                    input.autocomplete( "search", "" );
    //                    input.focus();
    //                });
    //        },

    //        destroy: function() {
    //            this.wrapper.remove();
    //            this.element.show();
    //            $.Widget.prototype.destroy.call( this );
    //        }
    //    });
    //})( jQuery );

    //$(function() {
    //    $( "#combobox" ).combobox();
    //    $( "#toggle" ).click(function() {
    //        $( "#combobox" ).toggle();
    //    });
    //});

        }
    }
}