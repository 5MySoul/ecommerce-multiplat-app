import ALink from '~/components/features/custom-link';

export default function Breadcrumb( props ) {
    return (
        <main className="main">
            <div className="page-header"
                style={ { backgroundImage: `url( ./images/home/shop-banner.jpg )`, backgroundColor: "#3C63A4" } }>
                <h3 className="page-subtitle text-dark">{ props.subTitle }</h3>
                <h1 className="page-title text-dark">{ props.title }</h1>
                <ul className="breadcrumb">
                    <li><ALink href="/"><i className="d-icon-home text-dark"></i></ALink></li>
                    <li className="delimiter text-dark">/</li>
                    {
                        props.parentUrl ?
                            <>
                                <li><ALink href={ props.parentUrl } className="text-dark">{ props.subTitle }</ALink></li>
                                <li className="delimiter text-dark">/</li>
                            </>
                            : ""
                    }
                    <li className="text-dark">{ props.title }</li>
                </ul>
            </div>
        </main >
    )
}