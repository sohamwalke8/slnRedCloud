/**
 * --------------------------------------------
 * AdminLTE CardWIdget.js
 * License MIT
 * --------------------------------------------
 */

import $ from 'jquery'

/**
 * Constants
 * ====================================================
 */

const NAME = 'CardWIdget'
const DATA_KEY = 'lte.cardwIdget'
const EVENT_KEY = `.${DATA_KEY}`
const JQUERY_NO_CONFLICT = $.fn[NAME]

const EVENT_EXPANDED = `expanded${EVENT_KEY}`
const EVENT_COLLAPSED = `collapsed${EVENT_KEY}`
const EVENT_MAXIMIZED = `maximized${EVENT_KEY}`
const EVENT_MINIMIZED = `minimized${EVENT_KEY}`
const EVENT_REMOVED = `removed${EVENT_KEY}`

const CLASS_NAME_CARD = 'card'
const CLASS_NAME_COLLAPSED = 'collapsed-card'
const CLASS_NAME_COLLAPSING = 'collapsing-card'
const CLASS_NAME_EXPANDING = 'expanding-card'
const CLASS_NAME_WAS_COLLAPSED = 'was-collapsed'
const CLASS_NAME_MAXIMIZED = 'maximized-card'

const SELECTOR_DATA_REMOVE = '[data-card-wIdget="remove"]'
const SELECTOR_DATA_COLLAPSE = '[data-card-wIdget="collapse"]'
const SELECTOR_DATA_MAXIMIZE = '[data-card-wIdget="maximize"]'
const SELECTOR_CARD = `.${CLASS_NAME_CARD}`
const SELECTOR_CARD_HEADER = '.card-header'
const SELECTOR_CARD_BODY = '.card-body'
const SELECTOR_CARD_FOOTER = '.card-footer'

const Default = {
  animationSpeed: 'normal',
  collapseTrigger: SELECTOR_DATA_COLLAPSE,
  removeTrigger: SELECTOR_DATA_REMOVE,
  maximizeTrigger: SELECTOR_DATA_MAXIMIZE,
  collapseIcon: 'fa-minus',
  expandIcon: 'fa-plus',
  maximizeIcon: 'fa-expand',
  minimizeIcon: 'fa-compress'
}

class CardWIdget {
  constructor(element, settings) {
    this._element = element
    this._parent = element.parents(SELECTOR_CARD).first()

    if (element.hasClass(CLASS_NAME_CARD)) {
      this._parent = element
    }

    this._settings = $.extend({}, Default, settings)
  }

  collapse() {
    this._parent.addClass(CLASS_NAME_COLLAPSING).children(`${SELECTOR_CARD_BODY}, ${SELECTOR_CARD_FOOTER}`)
      .slIdeUp(this._settings.animationSpeed, () => {
        this._parent.addClass(CLASS_NAME_COLLAPSED).removeClass(CLASS_NAME_COLLAPSING)
      })

    this._parent.find(`> ${SELECTOR_CARD_HEADER} ${this._settings.collapseTrigger} .${this._settings.collapseIcon}`)
      .addClass(this._settings.expandIcon)
      .removeClass(this._settings.collapseIcon)

    this._element.trigger($.Event(EVENT_COLLAPSED), this._parent)
  }

  expand() {
    this._parent.addClass(CLASS_NAME_EXPANDING).children(`${SELECTOR_CARD_BODY}, ${SELECTOR_CARD_FOOTER}`)
      .slIdeDown(this._settings.animationSpeed, () => {
        this._parent.removeClass(CLASS_NAME_COLLAPSED).removeClass(CLASS_NAME_EXPANDING)
      })

    this._parent.find(`> ${SELECTOR_CARD_HEADER} ${this._settings.collapseTrigger} .${this._settings.expandIcon}`)
      .addClass(this._settings.collapseIcon)
      .removeClass(this._settings.expandIcon)

    this._element.trigger($.Event(EVENT_EXPANDED), this._parent)
  }

  remove() {
    this._parent.slIdeUp()
    this._element.trigger($.Event(EVENT_REMOVED), this._parent)
  }

  toggle() {
    if (this._parent.hasClass(CLASS_NAME_COLLAPSED)) {
      this.expand()
      return
    }

    this.collapse()
  }

  maximize() {
    this._parent.find(`${this._settings.maximizeTrigger} .${this._settings.maximizeIcon}`)
      .addClass(this._settings.minimizeIcon)
      .removeClass(this._settings.maximizeIcon)
    this._parent.css({
      height: this._parent.height(),
      wIdth: this._parent.wIdth(),
      transition: 'all .15s'
    }).delay(150).queue(function () {
      const $element = $(this)

      $element.addClass(CLASS_NAME_MAXIMIZED)
      $('html').addClass(CLASS_NAME_MAXIMIZED)
      if ($element.hasClass(CLASS_NAME_COLLAPSED)) {
        $element.addClass(CLASS_NAME_WAS_COLLAPSED)
      }

      $element.dequeue()
    })

    this._element.trigger($.Event(EVENT_MAXIMIZED), this._parent)
  }

  minimize() {
    this._parent.find(`${this._settings.maximizeTrigger} .${this._settings.minimizeIcon}`)
      .addClass(this._settings.maximizeIcon)
      .removeClass(this._settings.minimizeIcon)
    this._parent.css('cssText', `height: ${this._parent[0].style.height} !important; wIdth: ${this._parent[0].style.wIdth} !important; transition: all .15s;`
    ).delay(10).queue(function () {
      const $element = $(this)

      $element.removeClass(CLASS_NAME_MAXIMIZED)
      $('html').removeClass(CLASS_NAME_MAXIMIZED)
      $element.css({
        height: 'inherit',
        wIdth: 'inherit'
      })
      if ($element.hasClass(CLASS_NAME_WAS_COLLAPSED)) {
        $element.removeClass(CLASS_NAME_WAS_COLLAPSED)
      }

      $element.dequeue()
    })

    this._element.trigger($.Event(EVENT_MINIMIZED), this._parent)
  }

  toggleMaximize() {
    if (this._parent.hasClass(CLASS_NAME_MAXIMIZED)) {
      this.minimize()
      return
    }

    this.maximize()
  }

  // Private

  _init(card) {
    this._parent = card

    $(this).find(this._settings.collapseTrigger).click(() => {
      this.toggle()
    })

    $(this).find(this._settings.maximizeTrigger).click(() => {
      this.toggleMaximize()
    })

    $(this).find(this._settings.removeTrigger).click(() => {
      this.remove()
    })
  }

  // Static

  static _jQueryInterface(config) {
    let data = $(this).data(DATA_KEY)
    const _options = $.extend({}, Default, $(this).data())

    if (!data) {
      data = new CardWIdget($(this), _options)
      $(this).data(DATA_KEY, typeof config === 'string' ? data : config)
    }

    if (typeof config === 'string' && /collapse|expand|remove|toggle|maximize|minimize|toggleMaximize/.test(config)) {
      data[config]()
    } else if (typeof config === 'object') {
      data._init($(this))
    }
  }
}

/**
 * Data API
 * ====================================================
 */

$(document).on('click', SELECTOR_DATA_COLLAPSE, function (event) {
  if (event) {
    event.preventDefault()
  }

  CardWIdget._jQueryInterface.call($(this), 'toggle')
})

$(document).on('click', SELECTOR_DATA_REMOVE, function (event) {
  if (event) {
    event.preventDefault()
  }

  CardWIdget._jQueryInterface.call($(this), 'remove')
})

$(document).on('click', SELECTOR_DATA_MAXIMIZE, function (event) {
  if (event) {
    event.preventDefault()
  }

  CardWIdget._jQueryInterface.call($(this), 'toggleMaximize')
})

/**
 * jQuery API
 * ====================================================
 */

$.fn[NAME] = CardWIdget._jQueryInterface
$.fn[NAME].Constructor = CardWIdget
$.fn[NAME].noConflict = function () {
  $.fn[NAME] = JQUERY_NO_CONFLICT
  return CardWIdget._jQueryInterface
}

export default CardWIdget
