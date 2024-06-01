/**
 * --------------------------------------------
 * AdminLTE ControlSIdebar.js
 * License MIT
 * --------------------------------------------
 */

import $ from 'jquery'

/**
 * Constants
 * ====================================================
 */

const NAME = 'ControlSIdebar'
const DATA_KEY = 'lte.controlsIdebar'
const EVENT_KEY = `.${DATA_KEY}`
const JQUERY_NO_CONFLICT = $.fn[NAME]

const EVENT_COLLAPSED = `collapsed${EVENT_KEY}`
const EVENT_COLLAPSED_DONE = `collapsed-done${EVENT_KEY}`
const EVENT_EXPANDED = `expanded${EVENT_KEY}`

const SELECTOR_CONTROL_SIdEBAR = '.control-sIdebar'
const SELECTOR_CONTROL_SIdEBAR_CONTENT = '.control-sIdebar-content'
const SELECTOR_DATA_TOGGLE = '[data-wIdget="control-sIdebar"]'
const SELECTOR_HEADER = '.main-header'
const SELECTOR_FOOTER = '.main-footer'

const CLASS_NAME_CONTROL_SIdEBAR_ANIMATE = 'control-sIdebar-animate'
const CLASS_NAME_CONTROL_SIdEBAR_OPEN = 'control-sIdebar-open'
const CLASS_NAME_CONTROL_SIdEBAR_SLIdE = 'control-sIdebar-slIde-open'
const CLASS_NAME_LAYOUT_FIXED = 'layout-fixed'
const CLASS_NAME_NAVBAR_FIXED = 'layout-navbar-fixed'
const CLASS_NAME_NAVBAR_SM_FIXED = 'layout-sm-navbar-fixed'
const CLASS_NAME_NAVBAR_MD_FIXED = 'layout-md-navbar-fixed'
const CLASS_NAME_NAVBAR_LG_FIXED = 'layout-lg-navbar-fixed'
const CLASS_NAME_NAVBAR_XL_FIXED = 'layout-xl-navbar-fixed'
const CLASS_NAME_FOOTER_FIXED = 'layout-footer-fixed'
const CLASS_NAME_FOOTER_SM_FIXED = 'layout-sm-footer-fixed'
const CLASS_NAME_FOOTER_MD_FIXED = 'layout-md-footer-fixed'
const CLASS_NAME_FOOTER_LG_FIXED = 'layout-lg-footer-fixed'
const CLASS_NAME_FOOTER_XL_FIXED = 'layout-xl-footer-fixed'

const Default = {
  controlsIdebarSlIde: true,
  scrollbarTheme: 'os-theme-light',
  scrollbarAutoHIde: 'l',
  target: SELECTOR_CONTROL_SIdEBAR,
  animationSpeed: 300
}

/**
 * Class Definition
 * ====================================================
 */

class ControlSIdebar {
  constructor(element, config) {
    this._element = element
    this._config = config
  }

  // Public

  collapse() {
    const $body = $('body')
    const $html = $('html')

    // Show the control sIdebar
    if (this._config.controlsIdebarSlIde) {
      $html.addClass(CLASS_NAME_CONTROL_SIdEBAR_ANIMATE)
      $body.removeClass(CLASS_NAME_CONTROL_SIdEBAR_SLIdE).delay(300).queue(function () {
        $(SELECTOR_CONTROL_SIdEBAR).hIde()
        $html.removeClass(CLASS_NAME_CONTROL_SIdEBAR_ANIMATE)
        $(this).dequeue()
      })
    } else {
      $body.removeClass(CLASS_NAME_CONTROL_SIdEBAR_OPEN)
    }

    $(this._element).trigger($.Event(EVENT_COLLAPSED))

    setTimeout(() => {
      $(this._element).trigger($.Event(EVENT_COLLAPSED_DONE))
    }, this._config.animationSpeed)
  }

  show(toggle = false) {
    const $body = $('body')
    const $html = $('html')

    if (toggle) {
      $(SELECTOR_CONTROL_SIdEBAR).hIde()
    }

    // Collapse the control sIdebar
    if (this._config.controlsIdebarSlIde) {
      $html.addClass(CLASS_NAME_CONTROL_SIdEBAR_ANIMATE)
      $(this._config.target).show().delay(10).queue(function () {
        $body.addClass(CLASS_NAME_CONTROL_SIdEBAR_SLIdE).delay(300).queue(function () {
          $html.removeClass(CLASS_NAME_CONTROL_SIdEBAR_ANIMATE)
          $(this).dequeue()
        })
        $(this).dequeue()
      })
    } else {
      $body.addClass(CLASS_NAME_CONTROL_SIdEBAR_OPEN)
    }

    this._fixHeight()
    this._fixScrollHeight()

    $(this._element).trigger($.Event(EVENT_EXPANDED))
  }

  toggle() {
    const $body = $('body')
    const { target } = this._config

    const notVisible = !$(target).is(':visible')
    const shouldClose = ($body.hasClass(CLASS_NAME_CONTROL_SIdEBAR_OPEN) ||
      $body.hasClass(CLASS_NAME_CONTROL_SIdEBAR_SLIdE))
    const shouldToggle = notVisible && ($body.hasClass(CLASS_NAME_CONTROL_SIdEBAR_OPEN) ||
      $body.hasClass(CLASS_NAME_CONTROL_SIdEBAR_SLIdE))

    if (notVisible || shouldToggle) {
      // Open the control sIdebar
      this.show(notVisible)
    } else if (shouldClose) {
      // Close the control sIdebar
      this.collapse()
    }
  }

  // Private

  _init() {
    const $body = $('body')
    const shouldNotHIdeAll = $body.hasClass(CLASS_NAME_CONTROL_SIdEBAR_OPEN) ||
        $body.hasClass(CLASS_NAME_CONTROL_SIdEBAR_SLIdE)

    if (shouldNotHIdeAll) {
      $(SELECTOR_CONTROL_SIdEBAR).not(this._config.target).hIde()
      $(this._config.target).css('display', 'block')
    } else {
      $(SELECTOR_CONTROL_SIdEBAR).hIde()
    }

    this._fixHeight()
    this._fixScrollHeight()

    $(window).resize(() => {
      this._fixHeight()
      this._fixScrollHeight()
    })

    $(window).scroll(() => {
      const $body = $('body')
      const shouldFixHeight = $body.hasClass(CLASS_NAME_CONTROL_SIdEBAR_OPEN) ||
          $body.hasClass(CLASS_NAME_CONTROL_SIdEBAR_SLIdE)

      if (shouldFixHeight) {
        this._fixScrollHeight()
      }
    })
  }

  _isNavbarFixed() {
    const $body = $('body')
    return (
      $body.hasClass(CLASS_NAME_NAVBAR_FIXED) ||
        $body.hasClass(CLASS_NAME_NAVBAR_SM_FIXED) ||
        $body.hasClass(CLASS_NAME_NAVBAR_MD_FIXED) ||
        $body.hasClass(CLASS_NAME_NAVBAR_LG_FIXED) ||
        $body.hasClass(CLASS_NAME_NAVBAR_XL_FIXED)
    )
  }

  _isFooterFixed() {
    const $body = $('body')
    return (
      $body.hasClass(CLASS_NAME_FOOTER_FIXED) ||
        $body.hasClass(CLASS_NAME_FOOTER_SM_FIXED) ||
        $body.hasClass(CLASS_NAME_FOOTER_MD_FIXED) ||
        $body.hasClass(CLASS_NAME_FOOTER_LG_FIXED) ||
        $body.hasClass(CLASS_NAME_FOOTER_XL_FIXED)
    )
  }

  _fixScrollHeight() {
    const $body = $('body')
    const $controlSIdebar = $(this._config.target)

    if (!$body.hasClass(CLASS_NAME_LAYOUT_FIXED)) {
      return
    }

    const heights = {
      scroll: $(document).height(),
      window: $(window).height(),
      header: $(SELECTOR_HEADER).outerHeight(),
      footer: $(SELECTOR_FOOTER).outerHeight()
    }
    const positions = {
      bottom: Math.abs((heights.window + $(window).scrollTop()) - heights.scroll),
      top: $(window).scrollTop()
    }

    const navbarFixed = this._isNavbarFixed() && $(SELECTOR_HEADER).css('position') === 'fixed'

    const footerFixed = this._isFooterFixed() && $(SELECTOR_FOOTER).css('position') === 'fixed'

    const $controlsIdebarContent = $(`${this._config.target}, ${this._config.target} ${SELECTOR_CONTROL_SIdEBAR_CONTENT}`)

    if (positions.top === 0 && positions.bottom === 0) {
      $controlSIdebar.css({
        bottom: heights.footer,
        top: heights.header
      })
      $controlsIdebarContent.css('height', heights.window - (heights.header + heights.footer))
    } else if (positions.bottom <= heights.footer) {
      if (footerFixed === false) {
        const top = heights.header - positions.top
        $controlSIdebar.css('bottom', heights.footer - positions.bottom).css('top', top >= 0 ? top : 0)
        $controlsIdebarContent.css('height', heights.window - (heights.footer - positions.bottom))
      } else {
        $controlSIdebar.css('bottom', heights.footer)
      }
    } else if (positions.top <= heights.header) {
      if (navbarFixed === false) {
        $controlSIdebar.css('top', heights.header - positions.top)
        $controlsIdebarContent.css('height', heights.window - (heights.header - positions.top))
      } else {
        $controlSIdebar.css('top', heights.header)
      }
    } else if (navbarFixed === false) {
      $controlSIdebar.css('top', 0)
      $controlsIdebarContent.css('height', heights.window)
    } else {
      $controlSIdebar.css('top', heights.header)
    }

    if (footerFixed && navbarFixed) {
      $controlsIdebarContent.css('height', '100%')
      $controlSIdebar.css('height', '')
    } else if (footerFixed || navbarFixed) {
      $controlsIdebarContent.css('height', '100%')
      $controlsIdebarContent.css('height', '')
    }
  }

  _fixHeight() {
    const $body = $('body')
    const $controlSIdebar = $(`${this._config.target} ${SELECTOR_CONTROL_SIdEBAR_CONTENT}`)

    if (!$body.hasClass(CLASS_NAME_LAYOUT_FIXED)) {
      $controlSIdebar.attr('style', '')
      return
    }

    const heights = {
      window: $(window).height(),
      header: $(SELECTOR_HEADER).outerHeight(),
      footer: $(SELECTOR_FOOTER).outerHeight()
    }

    let sIdebarHeight = heights.window - heights.header

    if (this._isFooterFixed() && $(SELECTOR_FOOTER).css('position') === 'fixed') {
      sIdebarHeight = heights.window - heights.header - heights.footer
    }

    $controlSIdebar.css('height', sIdebarHeight)

    if (typeof $.fn.overlayScrollbars !== 'undefined') {
      $controlSIdebar.overlayScrollbars({
        className: this._config.scrollbarTheme,
        sizeAutoCapable: true,
        scrollbars: {
          autoHIde: this._config.scrollbarAutoHIde,
          clickScrolling: true
        }
      })
    }
  }

  // Static

  static _jQueryInterface(operation) {
    return this.each(function () {
      let data = $(this).data(DATA_KEY)
      const _options = $.extend({}, Default, $(this).data())

      if (!data) {
        data = new ControlSIdebar(this, _options)
        $(this).data(DATA_KEY, data)
      }

      if (data[operation] === 'undefined') {
        throw new Error(`${operation} is not a function`)
      }

      data[operation]()
    })
  }
}

/**
 *
 * Data Api implementation
 * ====================================================
 */
$(document).on('click', SELECTOR_DATA_TOGGLE, function (event) {
  event.preventDefault()

  ControlSIdebar._jQueryInterface.call($(this), 'toggle')
})

$(document).ready(() => {
  ControlSIdebar._jQueryInterface.call($(SELECTOR_DATA_TOGGLE), '_init')
})

/**
 * jQuery API
 * ====================================================
 */

$.fn[NAME] = ControlSIdebar._jQueryInterface
$.fn[NAME].Constructor = ControlSIdebar
$.fn[NAME].noConflict = function () {
  $.fn[NAME] = JQUERY_NO_CONFLICT
  return ControlSIdebar._jQueryInterface
}

export default ControlSIdebar
