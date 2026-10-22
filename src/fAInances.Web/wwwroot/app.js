// Inline sub-forms (e.g. "new category") live inside the transaction form. Pressing Enter in them should
// trigger their own Blazor handler, not submit the surrounding form, so block the browser's implicit submit.
document.addEventListener('keydown', e => {
    if (e.key === 'Enter' && e.target instanceof Element && e.target.closest('[data-no-implicit-submit]')) {
        e.preventDefault();
    }
}, true);
