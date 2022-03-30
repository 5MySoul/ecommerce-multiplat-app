import React from 'react';

import ElementsList from '~/components/partials/elements/elements-list';

function ElementIndex () {
    return (
        <div className="mt-lg-4">
            <ElementsList adClass="bg-white" />
        </div>
    )
}

export default React.memo( ElementIndex );